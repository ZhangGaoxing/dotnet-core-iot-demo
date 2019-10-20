using System;
using System.IO.Ports;
using System.Text;

namespace SerialCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SerialPort usb = new SerialPort(portName: "/dev/ttyUSB0")) 
            {
                usb.BaudRate = 115200;
                usb.Encoding = Encoding.UTF8;
                usb.ReadTimeout = 500;
                usb.WriteTimeout = 500;

                usb.Open();

                using (SerialPort rpi = new SerialPort(portName: "/dev/ttyS0"))
                {
                    rpi.BaudRate = 115200;
                    rpi.Encoding = Encoding.UTF8;
                    rpi.ReadTimeout = 500;
                    rpi.WriteTimeout = 500;

                    rpi.Open();

                    for (int i = 0; i < 10; i++)
                    {
                        rpi.WriteLine($"Hello {i}!");
                        Console.WriteLine($"USB receive: {usb.ReadLine()}");
                    }

                    rpi.Close();
                }

                usb.Close();
            }
            
        }
    }
}
