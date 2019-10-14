// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;
using System.Device.I2c;
using Iot.Device.RadioReceiver;

namespace Tea5767Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            I2cConnectionSettings settings = new I2cConnectionSettings(1, Tea5767.DefaultI2cAddress);
            I2cDevice device = I2cDevice.Create(settings);

            using (Tea5767 radio = new Tea5767(device, FrequencyRange.Other, 103.3))
            {
                Console.ReadKey();
            }
        }
    }
}
