using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor
    {
        private bool carDetected(bool isCarAtEntrance)
        {
            
            return isCarAtEntrance;
        }

        private bool carLeftSensor(bool isCarStillAtEntry)
        {
            bool isCarAtSensor = isCarStillAtEntry;
            return isCarAtSensor;
        }
    }
}