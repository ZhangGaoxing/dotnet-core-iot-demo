// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;
using System.Device.I2c;
using System.Threading;

namespace Iot.Device.Sht3x.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            I2cConnectionSettings settings = new I2cConnectionSettings(1, (byte)I2cAddress.AddrLow);
            I2cDevice device = I2cDevice.Create(settings);

            using (Sht3x sensor = new Sht3x(device))
            {
                while (true)
                {
                    Console.WriteLine($"Temperature: {sensor.Temperature.Celsius} ℃");
                    Console.WriteLine($"Humidity: {sensor.Humidity} %");
                    Console.WriteLine();

                    Thread.Sleep(1000);
                }
            }
        }
    }
}
