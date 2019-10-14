// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.RadioTransmitter
{
    /// <summary>
    /// Kt0803 Register
    /// </summary>
    internal enum Register : byte
    {
        KT_CHSEL = 0x00,
        KT_CONFIG01 = 0x01,
        KT_CONFIG02 = 0x02,
        KT_CONFIG04 = 0x04,
        KT_CONFIG0B = 0x0B,
        KT_CONFIG0E = 0x0E,
        KT_CONFIG13 = 0x13,
    }
}
