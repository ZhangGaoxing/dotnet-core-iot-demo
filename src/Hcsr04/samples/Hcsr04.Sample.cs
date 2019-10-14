// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;
using System.Device.Gpio;
using System.Device.I2c;
using System.Device.Spi;
using System.Threading;
using Iot.Device.Hcsr04;

namespace Iot.Device.Hcsr04.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hcsr04 Sample!");

            using(var sonar = new Hcsr04(4, 17))
            {
                while(true)
                {
                    Console.WriteLine($"Distance: {sonar.Distance} cm");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
