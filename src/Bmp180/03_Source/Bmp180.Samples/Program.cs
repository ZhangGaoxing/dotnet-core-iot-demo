using System;
using System.Runtime.InteropServices;
using System.Threading;
using Iot.Device.Bmp180;

namespace Bmp180.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Iot.Device.Bmp180.Bmp180 sensor = new Iot.Device.Bmp180.Bmp180(Resolution.Standard, OSPlatform.Linux);

            sensor.Initialize();

            while (true)
            {
                Bmp180Data data = sensor.Read();

                Console.WriteLine($"Temperature: {data.Temperature.ToString("0.00")} ℃");
                Console.WriteLine($"Pressure: {data.Pressure.ToString("0.00")} Pa");
                Console.WriteLine($"Altitude: {data.Altitude.ToString("0.00")} m");
                Console.WriteLine();

                Thread.Sleep(2000);
            }
        }
    }
}
