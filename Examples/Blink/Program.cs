using Sharpduino;
using System.Threading;

namespace Blink
{
    class Program
    {
        static void Main(string[] args)
        {
            //Windows serial port
            var arduino = new ArduinoUno("COM4");

            arduino.SetPinMode(Sharpduino.Constants.ArduinoUnoPins.D13, Sharpduino.Constants.PinModes.Output);

            while (true)
            {
                arduino.SetDO(Sharpduino.Constants.ArduinoUnoPins.D13, true);
                Thread.Sleep(1000);
                arduino.SetDO(Sharpduino.Constants.ArduinoUnoPins.D13, false);
                Thread.Sleep(1000);
            }
        }
    }
}
