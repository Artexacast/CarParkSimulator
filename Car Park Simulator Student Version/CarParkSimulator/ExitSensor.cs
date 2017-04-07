using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator 
{
    class ExitSensor : Sensor
    {
        public ExitSensor()
        {
            carOnSensor = false;
        }

        public override bool carDetected()
        {
            carOnSensor = true;
            return carOnSensor;
        }

        public override bool carLeftSensor()
        {
            carOnSensor = false;
            return carOnSensor;
        }
    }
}
