// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Ads1115
{
    /// <summary>
    /// ADS1115 I2C Address Setting
    /// </summary>
    public enum I2cAddress
    {
        // Details in Datasheet P17 Table5

        /// <summary>
        /// ADDR Pin connect to GND
        /// </summary>
        GND = 0x48,
        /// <summary>
        /// ADDR Pin connect to VCC
        /// </summary>     
        VCC = 0x49,
        /// <summary>
        /// ADDR Pin connect to SDA
        /// </summary>
        SDA = 0x4A,
        /// <summary>
        /// ADDR Pin connect to SCL
        /// </summary>
        SCL = 0x4B
    }
}
