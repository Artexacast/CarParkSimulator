using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator 
{
    class ExitSensor : Sensor
    {
        private bool carDetected()
        {
            carOnSensor = true;
            return carOnSensor;
        }

        private bool carLeftSensor()
        {
            carOnSensor = false;
            return carOnSensor;
        }
    }
}
