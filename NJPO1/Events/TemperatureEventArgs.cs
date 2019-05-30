using System;
using System.Collections.Generic;
using System.Text;

namespace NJPO1.Events
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; set; }
    }
}
