// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Sht3x
{
    /// <summary>
    /// SHT3x Resolution (No Clock Stretching)
    /// </summary>
    public enum Resolution : byte
    {
        /// <summary>High resolution</summary>
        High = 0x00,
        /// <summary>Medium resolution</summary>
        Medium = 0x0B,
        /// <summary>Low resolution</summary>
        Low = 0x16
    }
}
