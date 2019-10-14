// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System.Device.Gpio;
using Iot.Units;

namespace Iot.Device.DHTxx
{
    /// <summary>
    /// Temperature and Humidity Sensor DHT11
    /// </summary>
    public class Dht11 : DhtBase
    {
        /// <summary>
        /// Create a DHT11 sensor
        /// </summary>
        /// <param name="pin">The pin number (GPIO number)</param>
        /// <param name="pinNumberingScheme">The GPIO pin numbering scheme</param>
        public Dht11(int pin, PinNumberingScheme pinNumberingScheme = PinNumberingScheme.Logical)
            : base(pin, pinNumberingScheme)
        { }

        internal override double GetHumidity(byte[] readBuff)
        {
            return readBuff[0] + readBuff[1] * 0.1;
        }

        internal override Temperature GetTemperature(byte[] readBuff)
        {
            var temp = readBuff[2] + readBuff[3] * 0.1;
            return Temperature.FromCelsius(temp);
        }
    }
}
