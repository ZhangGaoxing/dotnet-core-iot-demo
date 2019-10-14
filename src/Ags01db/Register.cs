// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Ags01db
{
    internal enum Register : byte
    {
        ASG_DATA_MSB = 0x00,
        ASG_DATA_LSB = 0x02,
        ASG_VERSION_MSB = 0x0A,
        ASG_VERSION_LSB = 0x01
    }
}