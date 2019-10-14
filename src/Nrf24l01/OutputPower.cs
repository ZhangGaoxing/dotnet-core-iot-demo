// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Nrf24l01
{
    /// <summary>
    /// nRF24l01 Output Power
    /// </summary>
    public enum OutputPower
    {
        /// <summary>
        /// -18dBm
        /// </summary>
        N18dBm = 0x00,
        /// <summary>
        /// -12dBm
        /// </summary>
        N12dBm = 0x01,
        /// <summary>
        /// -6dBm
        /// </summary>
        N06dBm = 0x02,
        /// <summary>
        /// 0dBm
        /// </summary>
        N00dBm = 0x03
    }
}
