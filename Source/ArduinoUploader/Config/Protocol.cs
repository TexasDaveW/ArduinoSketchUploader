using System.Diagnostics.CodeAnalysis;

namespace ArduinoUploader.Config
{
    /// <exclude />
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Protocol
    {
        Stk500v1,
        Stk500v2,
        Avr109
    }
}
