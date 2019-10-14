// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Sht3x
{
    /// <summary>
    /// SHT3x Register
    /// </summary>
    internal enum Register : ushort
    {
        SHT_MEAS = 0x24,
        SHT_RESET = 0x30A2,
        SHT_HEATER_ENABLE = 0x306D,
        SHT_HEATER_DISABLE = 0x3066
    }
}
