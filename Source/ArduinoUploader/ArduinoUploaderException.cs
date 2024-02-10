using System;

namespace ArduinoUploader
{
    /// <summary>
    /// Exception thrown when error occurs in this library
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ArduinoUploaderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArduinoUploaderException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ArduinoUploaderException(string message) : base(message)
        {
        }
    }
}