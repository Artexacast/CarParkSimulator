using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        private bool isCarOnSensor(bool hasCarArrived)
        {
            bool carOnSensor = hasCarArrived;
            return carOnSensor;
        }

        private abstract void carDetected()
        {

        }

        private abstract void carLeftSensor()
        {

        }
    }
}
