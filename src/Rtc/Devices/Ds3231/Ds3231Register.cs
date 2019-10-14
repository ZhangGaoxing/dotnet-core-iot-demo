// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

namespace Iot.Device.Rtc
{
    /// <summary>
    /// Register of DS3231
    /// </summary>
    internal enum Ds3231Register : byte
    {
        RTC_SEC_REG_ADDR = 0x00,
        RTC_MIN_REG_ADDR = 0x01,
        RTC_HOUR_REG_ADDR = 0x02,
        RTC_DAY_REG_ADDR = 0x03,
        RTC_DATE_REG_ADDR = 0x04,
        RTC_MONTH_REG_ADDR = 0x05,
        RTC_YEAR_REG_ADDR = 0x06,
        RTC_TEMP_MSB_REG_ADDR = 0x11,
        RTC_TEMP_LSB_REG_ADDR = 0x12,
    }
}
