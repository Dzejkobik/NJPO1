using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Events
{
    public class CelciusTemperatureDisplayer
    {
        public void OnTemperatureChanged(object source,TemperatureEventArgs eventArgs)
        {
            var temperature = eventArgs.Temperature;
            Console.WriteLine($"Temperature has changed, current temperature in celsius is: {temperature} C");
        }
    }
}
