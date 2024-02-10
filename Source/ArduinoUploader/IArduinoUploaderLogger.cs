using System;

namespace ArduinoUploader
{
    /// <summary>
    /// Interface for the ArduinoUploader logger
    /// </summary>
    public interface IArduinoUploaderLogger
    {
        /// <summary>
        /// Called to log an error
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Error(string message, Exception exception);

        /// <summary>
        /// Called to log a warning
        /// </summary>
        /// <param name="message">The message.</param>
        void Warn(string message);

        /// <summary>
        /// Called to log an information message
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Called to log a debug message
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>
        /// Called to log a trace message
        /// </summary>
        /// <param name="message">The message.</param>
        void Trace(string message);
    }
}
