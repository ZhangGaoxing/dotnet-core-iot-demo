// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Bh1750fvi
{
    internal enum Command : byte
    {
        PowerDown = 0b_0000_0000,
        PowerOn = 0b_0000_0001,
        Reset = 0b_0000_0111,
        MeasurementTimeHigh = 0b_0100_0000,
        MeasurementTimeLow = 0b_0110_0000,
    }
}