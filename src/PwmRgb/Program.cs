using System;
using System.Device.Pwm;
using System.Device.Pwm.Drivers;
using System.Threading;

namespace PwmRgb
{
    class Program
    {
        static void Main(string[] args)
        {
            using PwmChannel red = new SoftwarePwmChannel(pinNumber: 18, frequency: 400, dutyCycle: 0);
            using PwmChannel green = new SoftwarePwmChannel(pinNumber: 23, frequency: 400, dutyCycle: 0);
            using PwmChannel blue = new SoftwarePwmChannel(pinNumber: 24, frequency: 400, dutyCycle: 0);

            red.Start();
            green.Start();
            blue.Start();

            Breath(red, green, blue);

            red.Stop();
            green.Stop();
            blue.Stop();
        }

        public static void Breath(PwmChannel red, PwmChannel green, PwmChannel blue)
        {
            int r = 255, g = 0, b = 0;

            while (r != 0 && g != 255)
            {
                red.DutyCycle = r / 255D;
                green.DutyCycle = g / 255D;

                r--;
                g++;
                Thread.Sleep(10);
            }

            while (g != 0 && b != 255)
            {
                green.DutyCycle = g / 255D;
                blue.DutyCycle = b / 255D;

                g--;
                b++;
                Thread.Sleep(10);
            }

            while (b != 0 && r != 255)
            {
                blue.DutyCycle = b / 255D;
                red.DutyCycle = r / 255D;

                b--;
                r++;
                Thread.Sleep(10);
            }
        }
    }
}
