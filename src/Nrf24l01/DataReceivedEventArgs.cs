// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;

namespace Iot.Device.Nrf24l01
{
    /// <summary>
    /// nRF24L01 Data Received Event Args
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// nRF24L01 Received Data
        /// </summary>
        public byte[] Data { get; }

        /// <summary>
        /// Constructs DataReceivedEventArgs instance
        /// </summary>
        /// <param name="data">Data received</param>
        public DataReceivedEventArgs(byte[] data)
        {
            Data = data;
        }
    }
}
