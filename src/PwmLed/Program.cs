using System;
using System.Device.Pwm;
using System.Threading;

namespace PwmLed
{
    class Program
    {
        static void Main(string[] args)
        {
            int brightness = 0;
            using PwmChannel pwm = PwmChannel.Create(chip: 0, channel: 0, frequency: 400, dutyCyclePercentage: 0);

            pwm.Start();

            while (brightness != 255)
            {
                pwm.DutyCycle = brightness / 255D;

                brightness++;
                Thread.Sleep(10);
            }

            while (brightness != 0)
            {
                pwm.DutyCycle = brightness / 255D;

                brightness--;
                Thread.Sleep(10);
            }

            pwm.Stop();
        }
    }
}
