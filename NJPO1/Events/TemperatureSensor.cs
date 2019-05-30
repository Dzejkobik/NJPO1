using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Events
{
    public class TemperatureSensor
    {
        private double _temperature;
        public double Temperature
        {
            get { return _temperature;}
            set
            {
                _temperature = value;
                OnTemperatureChanged();
            }
        }

        public delegate void TemperatureChangedEventHandler(object source, TemperatureEventArgs eventArgs);

        public event TemperatureChangedEventHandler TemperatureChanged;
        protected virtual void OnTemperatureChanged()
        {
            if (TemperatureChanged != null)
            {
                TemperatureChanged(this,new TemperatureEventArgs(){Temperature = this.Temperature});
            }
        }
    }
}
