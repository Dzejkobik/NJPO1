using System;
using NJPO1.Decorator;
using NJPO1.Events;

namespace NJPO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var decoratorRun = new DecoratorRun();
            //decoratorRun.Run();

            var temperatureSensor = new TemperatureSensor();
            var celsiusTemperatureDisplayer = new CelciusTemperatureDisplayer();
            var farenheitTemperatureDisplayer = new FarenheitTemperatureDisplayer();
            var kelvinTemperatureDisplayer = new KelvinTemperatureDisplayer();

            temperatureSensor.TemperatureChanged += celsiusTemperatureDisplayer.OnTemperatureChanged;
            temperatureSensor.TemperatureChanged += farenheitTemperatureDisplayer.OnTemperatureChanged;
            temperatureSensor.TemperatureChanged += kelvinTemperatureDisplayer.OnTemperatureChanged;

            temperatureSensor.Temperature = 29;
        }
    }
}
