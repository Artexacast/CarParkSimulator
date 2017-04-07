using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    abstract class Sensor
    {
        public bool isCarOnSensor()
        {
            return carOnSensor;
        }

        public abstract bool carDetected();

        public abstract bool carLeftSensor();
        

        protected bool carOnSensor;
    }
}
