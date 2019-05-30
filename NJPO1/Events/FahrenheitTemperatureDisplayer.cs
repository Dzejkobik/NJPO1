using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Events
{
    public class FahrenheitTemperatureDisplayer
    {
        public void OnTemperatureChanged(object source,TemperatureEventArgs eventArgs)
        {
            var temperature = (eventArgs.Temperature * 9/5) + 32;
            Console.WriteLine($"Temperature has changed, current temperature in Fahrenheit is: {temperature} F");
        }
    }
}
