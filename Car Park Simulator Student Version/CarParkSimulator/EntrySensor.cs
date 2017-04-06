using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor
    {
        public  bool carDetected()
        {
            carOnSensor = true;
            return carOnSensor;
        }

        public bool carLeftSensor()
        {
            carOnSensor = false;
            return carOnSensor;
        }
    }
}