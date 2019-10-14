// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Bh1750fvi
{
    /// <summary>
    /// BH1750FVI I2C Address
    /// </summary>
    public enum I2cAddress : byte
    {
        /// <summary>
        /// ADD Pin connect to high power level
        /// </summary>
        AddPinHigh = 0x5C,
        /// <summary>
        /// ADD Pin connect to low power level 
        /// </summary>     
        AddPinLow = 0x23
    }
}