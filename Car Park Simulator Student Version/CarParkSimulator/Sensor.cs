using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        public bool isCarOnSensor()
        {
            return carOnSensor;
        }

        public abstract void carDetected()
        {

        }

        public abstract void carLeftSensor()
        {

        }

        protected bool carOnSensor;
    }
}
