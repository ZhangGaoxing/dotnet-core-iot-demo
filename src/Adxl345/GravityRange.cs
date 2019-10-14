// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Adxl345
{
    /// <summary>
    /// Gravity Measurement Range
    /// </summary>
    public enum GravityRange
    {
        /// <summary>
        /// ±2G
        /// </summary>
        Range02 = 0x00,
        /// <summary>
        /// ±4G
        /// </summary>
        Range04 = 0x01,
        /// <summary>
        /// ±8G
        /// </summary>
        Range08 = 0x02,
        /// <summary>
        /// ±16G
        /// </summary>
        Range16 = 0x03
    };
}
