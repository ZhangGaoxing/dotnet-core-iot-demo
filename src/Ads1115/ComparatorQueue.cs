// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Ads1115
{
    /// <summary>
    /// Comparator Queue.
    /// </summary>
    public enum ComparatorQueue
    {
        /// <summary>Assert after one</summary>
        AssertAfterOne = 0x00,
        /// <summary>Assert after two</summary>
        AssertAfterTwo = 0x01,
        /// <summary>Assert after four</summary>
        AssertAfterFour = 0x02,
        /// <summary>Disable</summary>
        Disable = 0x03
    }
}
