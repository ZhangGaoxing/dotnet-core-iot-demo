// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;
using System.Device.I2c;
using System.Threading;

namespace Iot.Device.Bh1750fvi.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            I2cConnectionSettings settings = new I2cConnectionSettings(busId: 1, (int)I2cAddress.AddPinLow);
            I2cDevice device = I2cDevice.Create(settings);

            using (Bh1750fvi sensor = new Bh1750fvi(device))
            {
                while (true)
                {
                    Console.WriteLine($"Illuminance: {sensor.Illuminance}Lux");

                    Thread.Sleep(1000);
                }
            }
        }
    }
}
