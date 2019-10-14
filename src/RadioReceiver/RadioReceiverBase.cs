// This repository is licensed under the MIT License © Zhang Yuexin
// https://github.com/ZhangGaoxing/dotnet-core-iot-demo/blob/master/LICENSE

using System;

namespace Iot.Device.RadioReceiver
{
    /// <summary>
    /// Base class for radio receiver.
    /// </summary>
    public abstract class RadioReceiverBase : IDisposable
    {
        /// <summary>
        /// Radio receiver FM frequency.
        /// </summary>
        public abstract double Frequency { get; set; }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the RadioReceiverBase and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing) { }
    }
}
