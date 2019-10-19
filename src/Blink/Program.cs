using System;
using System.Device.Gpio;
using System.Threading;

namespace Blink
{
    class Program
    {
        static void Main(string[] args)
        {
            int pinNumber = 17;
            int delayTime = 1000;

            // get the GPIO controller
            using (GpioController controller = new GpioController(PinNumberingScheme.Logical))
            {
                // open PIN 17
                controller.OpenPin(pinNumber, PinMode.Output);

                // loop
                while (true)
                {
                    Console.WriteLine($"Light for {delayTime}ms");
                    // turn the LED on
                    controller.Write(pinNumber, PinValue.High);
                    // wait for a second
                    Thread.Sleep(delayTime);

                    Console.WriteLine($"Dim for {delayTime}ms");
                    // turn the LED off
                    controller.Write(pinNumber, PinValue.Low);
                    // wait for a second
                    Thread.Sleep(delayTime);
                }
            }      
        }
    }
}
