// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Lm75
{
    /// <summary>
    /// LM75 Register
    /// </summary>
    internal enum Register : byte
    {
        LM_TEMP = 0x00,
        LM_CONFIG = 0x01,
        LM_THYST = 0x02,
        LM_TOS = 0x03
    }
}
