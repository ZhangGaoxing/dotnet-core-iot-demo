// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Ads1115
{
    /// <summary>
    /// Register of ADS1115
    /// </summary>
    internal enum Register : byte
    {
        ADC_CONVERSION_REG_ADDR = 0x00,
        ADC_CONFIG_REG_ADDR = 0x01,
    }
}
