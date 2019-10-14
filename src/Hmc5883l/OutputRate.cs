// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Hmc5883l
{
    /// <summary>
    /// HMC5883L Typical Data Output Rate (Hz)
    /// </summary>
    public enum OutputRate
    {
        /// <summary>
        /// 0.75 Hz
        /// </summary>
        Rate00_75 = 0x00,

        /// <summary>
        /// 1.5 Hz
        /// </summary>
        Rate01_5 = 0x01,

        /// <summary>
        /// 3 Hz
        /// </summary>
        Rate03 = 0x02,

        /// <summary>
        /// 7.5 Hz
        /// </summary>
        Rate07_5 = 0x03,

        /// <summary>
        /// 15 Hz
        /// </summary>
        Rate15 = 0x04,

        /// <summary>
        /// 30 Hz
        /// </summary>
        Rate30 = 0x05,

        /// <summary>
        /// 75 Hz
        /// </summary>
        Rate75 = 0x06,
    }
}
