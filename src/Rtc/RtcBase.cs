// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;

namespace Iot.Device.Rtc
{
    /// <summary>
    /// Base class for real time clocks (RTC)
    /// </summary>
    public abstract class RtcBase : IDisposable
    {
        /// <summary>
        /// The Device's <see cref="System.DateTime"/>
        /// </summary>
        public virtual DateTime DateTime { get => ReadTime(); set => SetTime(value); }

        /// <summary>
        /// Set the device time
        /// </summary>
        /// <param name="time">Time</param>
        protected abstract void SetTime(DateTime time);

        /// <summary>
        /// Read time from the device
        /// </summary>
        /// <returns>Time from the device</returns>
        protected abstract DateTime ReadTime();

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the RtcBase and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing) { }
    }
}
