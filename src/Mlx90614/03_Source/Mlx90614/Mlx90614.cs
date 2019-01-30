using System;
using System.Device.I2c;
using System.Device.I2c.Drivers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Iot.Device.Mlx90614
{
    public struct Mlx90614Data
    {
        public double AmbientTemp;
        public double ObjectTemp;
    }

    public class Mlx90614 : IDisposable
    {
        private I2cDevice sensor;

        private const byte MLX90614_ADDR = 0x5A;
        private const byte MLX90614_AMBIENT_TEMP = 0x06;
        private const byte MLX90614_OBJECT_TEMP = 0x07;

        private readonly int _busId;
        private readonly OSPlatform _os;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="busId">I2C Bus ID</param>
        public Mlx90614(OSPlatform os, int busId = 1)
        {
            _busId = busId;
            _os = os;
        }

        /// <summary>
        /// Initialize
        /// </summary>
        public void Initialize()
        {
            var settings = new I2cConnectionSettings(_busId, MLX90614_ADDR);

            if (_os == OSPlatform.Linux)
            {
                sensor = new UnixI2cDevice(settings);
            }
            else if (_os == OSPlatform.Windows)
            {
                sensor = new Windows10I2cDevice(settings);
            }
        }

        /// <summary>
        /// Read Seneor Data
        /// </summary>
        /// <returns>Mlx90614 Data</returns>
        public Mlx90614Data Read()
        {
            byte[] readBuf = new byte[2];
            Mlx90614Data data = new Mlx90614Data();

            sensor.Write(new byte[] { MLX90614_AMBIENT_TEMP });
            sensor.Read(readBuf);
            data.AmbientTemp = BitConverter.ToInt16(readBuf, 0) * 0.02 - 273.15;

            sensor.Write(new byte[] { MLX90614_OBJECT_TEMP });
            sensor.Read(readBuf);
            data.ObjectTemp = BitConverter.ToInt16(readBuf, 0) * 0.02 - 273.15;

            return data;
        }

        /// <summary>
        /// Get MLX90614 Device
        /// </summary>
        /// <returns>I2c Device</returns>
        public I2cDevice GetDevice()
        {
            return sensor;
        }

        /// <summary>
        /// Cleanup
        /// </summary>
        public void Dispose()
        {
            sensor.Dispose();
        }
    }
}
