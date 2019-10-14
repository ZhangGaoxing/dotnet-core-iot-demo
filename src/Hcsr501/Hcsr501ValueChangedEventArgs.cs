// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;
using System.Device.Gpio;

namespace Iot.Device.Hcsr501
{
    /// <summary>
    /// HC-SR501 Value Changed Event Args
    /// </summary>
    public class Hcsr501ValueChangedEventArgs : EventArgs
    {
        /// <summary>
        /// HC-SR501 OUT Pin Value
        /// </summary>
        public PinValue PinValue { get; private set; }

        /// <summary>
        /// Constructs Hcsr501ValueChangedEventArgs instance
        /// </summary>
        /// <param name="value">New value of pin</param>
        public Hcsr501ValueChangedEventArgs(PinValue value)
        {
            PinValue = value;
        }
    }
}
