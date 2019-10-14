// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Hmc5883l
{
    /// <summary>
    /// Register of HMC5883L
    /// </summary>
    internal enum Register : byte
    {
        HMC_CONFIG_REG_A_ADDR = 0x00,
        HMC_CONFIG_REG_B_ADDR = 0x01,
        HMC_MODE_REG_ADDR = 0x02,
        HMC_X_MSB_REG_ADDR = 0x03,
        HMC_Z_MSB_REG_ADDR = 0x05,
        HMC_Y_MSB_REG_ADDR = 0x07,
        HMC_STATUS_REG_ADDR = 0x09
    }
}
