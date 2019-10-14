// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.RadioTransmitter
{
    /// <summary>
    /// Bass Boost
    /// </summary>
    public enum BassBoost : byte
    {
        /// <summary>
        /// Disable
        /// </summary>
        BoostDisable = 0,

        /// <summary>
        /// 5 dB
        /// </summary>
        Boost05dB = 1,

        /// <summary>
        /// 11 dB
        /// </summary>
        Boost11dB = 2,

        /// <summary>
        /// 17 dB
        /// </summary>
        Boost17dB = 3
    }
}
