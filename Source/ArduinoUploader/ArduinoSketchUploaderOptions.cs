using ArduinoUploader.Hardware;

namespace ArduinoUploader
{
    /// <summary>
    /// Options for the ArduinoSketchUploader class
    /// </summary>
    public class ArduinoSketchUploaderOptions
    {
        /// <summary>
        /// Gets or sets the name of the file.  
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the name of the port.  Will attempt to auto-detect if not provided.
        /// </summary>
        public string PortName { get; set; }

        /// <summary>
        /// Gets or sets the arduino model.
        /// </summary>
        public ArduinoModel ArduinoModel { get; set; }

        /// <summary>
        /// Gets or sets the baud rate used for uploading. Defaults to 57600.
        /// </summary>
        public int BaudRate { get; set; } = 57600;
    }
}
