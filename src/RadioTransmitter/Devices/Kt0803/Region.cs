// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.RadioTransmitter
{
    /// <summary>
    /// Region (Pre-Emphasis time constant)
    /// </summary>
    public enum Region
    {
        /// <summary>
        /// Pre-Emphasis time constant is 75μs
        /// </summary>
        America,

        /// <summary>
        /// Pre-Emphasis time constant is 75μs
        /// </summary>
        Japan,

        /// <summary>
        /// Pre-Emphasis time constant is 50μs
        /// </summary>
        Europe,

        /// <summary>
        /// Pre-Emphasis time constant is 50μs
        /// </summary>
        Australia,

        /// <summary>
        /// Pre-Emphasis time constant is 50μs
        /// </summary>
        China,

        /// <summary>
        /// Pre-Emphasis time constant is 50μs
        /// </summary>
        Other
    }
}
