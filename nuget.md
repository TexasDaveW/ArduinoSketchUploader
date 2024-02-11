# ArduinoUploaderCore

A .NET library that can be used to upload a compiled sketch (.HEX) directly to an Arduino board over USB. It talks to the boards bootloader over the serial (USB) connection, much like *avrdude* does (when invoked from the Arduino IDE, or from the command line).

This is a fork of the [ArduinoSketchUploader](https://github.com/twinearthsoftware/ArduinoSketchUploader) project created by Christophe Diericx. It has been altered to use .NET Standard as well as adding support for the new Arduino Nano bootloader.

This project is located at [https://github.com/codaris/ArduinoSketchUploader](https://github.com/codaris/ArduinoSketchUploader)

## Compatibility 

The library has been tested with the following configurations:

| Arduino Model | MCU           | Bootloader protocol                                |
| ------------- |:-------------:| --------------------------------------------------:|
| Leonardo      | ATMega32U4    | [AVR109](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/AVR109.pdf)|
| Mega 1284     | ATMega1284    | [STK500v1](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/STK500v1.pdf)|
| Mega 2560     | ATMega2560    | [STK500v2](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/STK500v2.pdf)|
| Micro         | ATMega32U4    | [AVR109](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/AVR109.pdf)|
| Nano (R2)     | ATMega168     | [STK500v1](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/STK500v1.pdf)|
| Nano (R3)     | ATMega328P    | [STK500v1](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/STK500v1.pdf)|
| Uno (R3)      | ATMega328P    | [STK500v1](https://github.com/codaris/ArduinoSketchUploader/blob/master/Documentation/Documentation/STK500v1.pdf)|


## Getting Started

Install the package using the nuget package manager console:

```
Install-Package ArduinoUploaderCore
```

The following minimal snippet shows how to upload a .HEX file to an Arduino (UNO) board attached at COM port 3:

```csharp
var uploader = new ArduinoSketchUploader(
    new ArduinoSketchUploaderOptions()
    {
        FileName = @"C:\MyHexFiles\UnoHexFile.ino.hex",
        PortName = "COM3",
        ArduinoModel = ArduinoModel.UnoR3
    });

uploader.UploadSketch();
```

One can try to auto-detect the COM port by omitting it.

## Documentation

View the API documentation by clicking the link below:

* [ArduinoUploaderCore Documentation](https://codaris.github.io/ArduinoSketchUploader/)

## Logging 

In earlier versions of the library, it emitted log messages through a dependency on `NLog`. From an architectural point of view, it is suboptimal to be forcing a dependency on a particular logging framework from library code.

A simple `IArduinoUploaderLogger` interface is exposed from within the library. Implement this interface, and pass an instance into the ArduinoSketchUploader constructor if you want to consume log messages (in varying levels, from *Info* to *Trace*).

Implementing the interface using `NLog` consists of nothing more than this:

```
private class NLogArduinoUploaderLogger : IArduinoUploaderLogger
{
    private static readonly Logger Logger = LogManager.GetLogger("ArduinoSketchUploader");

    public void Error(string message, Exception exception)
    {
        Logger.Error(exception, message);
    }

    public void Warn(string message)
    {
        Logger.Warn(message);
    }

    public void Info(string message)
    {
        Logger.Info(message);
    }

    public void Debug(string message)
    {
        Logger.Debug(message);
    }

    public void Trace(string message)
    {
        Logger.Trace(message);
    }
}
```
