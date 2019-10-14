// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Hmc5883l
{
    /// <summary>
    /// Number of samples averaged (1 to 8) per measurement output.
    /// </summary>
    public enum SamplesAmount : byte
    {
        /// <summary>
        /// 1 (Default) samples per measurement output.
        /// </summary>
        One = 0b_0000_0000,
        /// <summary>
        /// 2 samples per measurement output.
        /// </summary>
        Two = 0b_0010_0000,
        /// <summary>
        /// 4 samples per measurement output.
        /// </summary>
        Four = 0b_0100_0000,
        /// <summary>
        /// 8 samples per measurement output.
        /// </summary>
        Eight = 0b_0110_0000
    }
}