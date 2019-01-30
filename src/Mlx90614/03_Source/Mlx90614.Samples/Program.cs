using System;
using System.Threading;
using System.Runtime.InteropServices;

using Iot.Device.Mlx90614;

namespace Mlx90614.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Iot.Device.Mlx90614.Mlx90614 sensor = new Iot.Device.Mlx90614.Mlx90614(OSPlatform.Linux);

            sensor.Initialize();

            while (true)
            {
                Mlx90614Data data = sensor.Read();

                Console.WriteLine($"Ambient Temperature: {data.AmbientTemp} ℃");
                Console.WriteLine($"Object Temperature: {data.ObjectTemp} ℃");
                Console.WriteLine();

                Thread.Sleep(2000);
            }
        }
    }
}
