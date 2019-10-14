// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Hmc5883l
{
    /// <summary>
    /// The mode of HMC5883L measuring
    /// </summary>
    public enum MeasuringMode
    {
        /// <summary>
        /// Continuous Measuring Mode
        /// </summary>
        Continuous = 0x00,
        /// <summary>
        /// Single Measuring Mode (Measure only once. In this mode, OutputRate will be invalid.)
        /// </summary>
        Single = 0x01
    }
}
