// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Max44009
{
    internal enum Register : byte
    {
        MAX_CONFIG = 0x02,
        MAX_LUX_HIGH = 0x03,
        MAX_LUX_LOW = 0x04
    }
}
