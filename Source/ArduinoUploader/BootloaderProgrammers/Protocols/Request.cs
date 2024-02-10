namespace ArduinoUploader.BootloaderProgrammers.Protocols
{
    internal abstract class Request : IRequest
    {
        public byte[] Bytes { get; set; }
    }
}