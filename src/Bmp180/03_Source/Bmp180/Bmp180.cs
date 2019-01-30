using System;
using System.Device.I2c;
using System.Device.I2c.Drivers;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Iot.Device.Bmp180
{
    /// <summary>
    /// Calibration coefficients
    /// </summary>
    public struct Calibration
    {
        public short AC1;
        public short AC2;
        public short AC3;
        public ushort AC4;
        public ushort AC5;
        public ushort AC6;
        public short B1;
        public short B2;
        public short MB;
        public short MC;
        public short MD;
    }

    /// <summary>
    /// BMP180 sensor data
    /// </summary>
    public struct Bmp180Data
    {
        /// <summary>
        /// Temperature : ℃
        /// </summary>
        public double Temperature;
        /// <summary>
        /// Pressure : Pa
        /// </summary>
        public double Pressure;
        /// <summary>
        /// (Inaccurate) Altitude : m 
        /// </summary>
        public double Altitude;
    }

    /// <summary>
    /// BMP180 sensor pressure sampling accuracy modes
    /// </summary>
    public enum Resolution
    {
        UltraLowPower = 0,
        Standard = 1,
        HighResolution = 2,
        UltrHighResolution = 3
    }

    public class Bmp180
    {
        private I2cDevice sensor;
        private const byte BMP180_ADDR = 0x77;

        private readonly int oss;                                // Oversampling setting
        private readonly int pressDelay;
        private readonly int _busId;
        private readonly OSPlatform _os;

        #region Calibration MSB
        private Calibration cal;
        private const byte ADDR_CALIBRATION_AC1 = 0xAA;
        private const byte ADDR_CALIBRATION_AC2 = 0xAC;
        private const byte ADDR_CALIBRATION_AC3 = 0xAE;
        private const byte ADDR_CALIBRATION_AC4 = 0xB0;
        private const byte ADDR_CALIBRATION_AC5 = 0xB2;
        private const byte ADDR_CALIBRATION_AC6 = 0xB4;
        private const byte ADDR_CALIBRATION_B1 = 0xB6;
        private const byte ADDR_CALIBRATION_B2 = 0xB8;
        private const byte ADDR_CALIBRATION_MB = 0xBA;
        private const byte ADDR_CALIBRATION_MC = 0xBC;
        private const byte ADDR_CALIBRATION_MD = 0xBE;
        #endregion 

        /// <summary>
        /// Constructor
        /// </summary>
        public Bmp180(Resolution resolution, OSPlatform os, int busId = 1)
        {
            oss = (short)resolution;
            switch (resolution)
            {
                case Resolution.UltraLowPower:
                    pressDelay = 5;
                    break;
                case Resolution.Standard:
                    pressDelay = 8;
                    break;
                case Resolution.HighResolution:
                    pressDelay = 14;
                    break;
                case Resolution.UltrHighResolution:
                    pressDelay = 26;
                    break;
            }

            _busId = busId;
            _os = os;
        }

        /// <summary>
        /// Initialize
        /// </summary>
        public void Initialize()
        {
            var settings = new I2cConnectionSettings(_busId, BMP180_ADDR);

            if (_os == OSPlatform.Linux)
            {
                sensor = new UnixI2cDevice(settings);
            }
            else if (_os == OSPlatform.Windows)
            {
                sensor = new Windows10I2cDevice(settings);
            }

            ReadCalibrationData();
        }

        /// <summary>
        /// Read data from BMP180 sensor
        /// </summary>
        /// <returns>BMP180Data</returns>
        public Bmp180Data Read()
        {
            Bmp180Data data;
            double UT = ReadUncompensatedTempData();
            double UP = ReadUncompensatedPressData();

            CalculateTrueData(UT, UP, out data.Temperature, out data.Pressure);

            data.Altitude = 44330 * (1 - Math.Pow(data.Pressure / 101325, 0.1903));
            //data.Altitude = ((Math.Pow((101325 / data.Pressure), 0.190223) - 1) * (data.Temperature + 273.15)) / 0.0065;
            return data;
        }

        /// <summary>
        /// Cleanup
        /// </summary>
        public void Dispose()
        {
            sensor.Dispose();
        }

        /// <summary>
        /// Get BMP180 Device
        /// </summary>
        /// <returns></returns>
        public I2cDevice GetDevice()
        {
            return sensor;
        }

        #region Private Methods

        /// <summary>
        /// Read calibration data from sensor
        /// </summary>
        private void ReadCalibrationData()
        {
            byte[] readBuf = new byte[2];

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC1 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC1 = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC2 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC2 = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC3 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC3 = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC4 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC4 = BitConverter.ToUInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC5 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC5 = BitConverter.ToUInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_AC6 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.AC6 = BitConverter.ToUInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_B1 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.B1 = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_B2 });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.B2 = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_MB });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.MB = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_MC });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.MC = BitConverter.ToInt16(readBuf, 0);

            sensor.Write(new byte[] { ADDR_CALIBRATION_MD });
            sensor.Read(readBuf);
            Array.Reverse(readBuf);
            cal.MD = BitConverter.ToInt16(readBuf, 0);
        }

        /// <summary>
        /// Get uncompensated temperature
        /// </summary>
        /// <returns>Uncompensated temperature</returns>
        private double ReadUncompensatedTempData()
        {
            double UT;
            byte[] readBuf = new byte[2];

            sensor.Write(new byte[] { 0xF4, 0x2E });
            Thread.Sleep(5);
            sensor.Write(new byte[] { 0xF6 });
            sensor.Read(readBuf);

            UT = readBuf[0] * Math.Pow(2, 8) + readBuf[1];

            return UT;
        }

        /// <summary>
        /// Get uncompensated pressure
        /// </summary>
        /// <returns>Uncompensated pressure</returns>
        private double ReadUncompensatedPressData()
        {
            double UP;
            byte[] readBuf = new byte[3];
            byte op = (byte)(0x34 + (oss << 6));

            sensor.Write(new byte[] { 0xF4, op });
            Thread.Sleep(pressDelay);
            sensor.Write(new byte[] { 0xF6 });
            sensor.Read(readBuf);

            UP = (readBuf[0] * Math.Pow(2, 16) + readBuf[1] * Math.Pow(2, 8) + readBuf[2]) / Math.Pow(2, (8 - oss));

            return UP;
        }

        /// <summary>
        /// Get true data by calculating
        /// </summary>
        /// <param name="UT">Uncompensated temperature</param>
        /// <param name="UP">Uncompensated pressure</param>
        /// <param name="T">Out true temperature</param>
        /// <param name="P">Out true pressure</param>
        private void CalculateTrueData(double UT, double UP, out double T, out double P)
        {
            double X1, X2, B5;
            // Get true temperature
            X1 = (UT - cal.AC6) * cal.AC5 / Math.Pow(2, 15);
            X2 = cal.MC * Math.Pow(2, 11) / (X1 + cal.MD);
            B5 = X1 + X2;
            T = (B5 + 8) / Math.Pow(2, 4) / 10;

            double B3, B4, B6, B7, X3, p;
            // Get true pressure
            B6 = B5 - 4000;
            X1 = (cal.B2 * (B6 * B6 / Math.Pow(2, 12))) / Math.Pow(2, 11);
            X2 = cal.AC2 * B6 / Math.Pow(2, 11);
            X3 = X1 + X2;
            B3 = ((cal.AC1 * 4 + X3) * Math.Pow(2, oss) + 2) / 4;
            X1 = cal.AC3 * B6 / Math.Pow(2, 13);
            X2 = (cal.B1 * (B6 * B6 / Math.Pow(2, 12))) / Math.Pow(2, 16);
            X3 = ((X1 + X2) + 2) / 4;
            B4 = cal.AC4 * (ulong)(X3 + 32768) / Math.Pow(2, 15);
            B7 = ((ulong)UP - B3) * (50000 / Math.Pow(2, oss));
            if (B7 < 0x80000000)
            {
                p = (B7 * 2) / B4;
            }
            else
            {
                p = (B7 / B4) * 2;
            }
            X1 = (p / Math.Pow(2, 8)) * (p / Math.Pow(2, 8));
            X1 = (X1 * 3038) / Math.Pow(2, 16);
            X2 = (-7357 * p) / Math.Pow(2, 16);
            P = p + (X1 + X2 + 3791) / 16;
        }

        #endregion
    }
}
