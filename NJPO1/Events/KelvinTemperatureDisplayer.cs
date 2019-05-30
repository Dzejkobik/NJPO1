using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Events
{
    public class KelvinTemperatureDisplayer
    {
        public void OnTemperatureChanged(object source, TemperatureEventArgs eventArgs)
        {
            var temperature = eventArgs.Temperature + 237.15;
            Console.WriteLine($"Temperature has changed, current temperature in Kelvin's is: {temperature} K");
        }
    }
}
