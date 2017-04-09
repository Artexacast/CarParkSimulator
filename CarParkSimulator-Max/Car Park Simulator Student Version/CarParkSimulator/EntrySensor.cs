using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor
    {
        private CarPark carPark;

        public EntrySensor(CarPark carPark)
        {
            carOnSensor = false;
            this.carPark = carPark;
        }

        public override bool carDetected()
        {
            carOnSensor = true;
            carPark.carArrivedAtEntrance();
            return carOnSensor;
        }

        public override bool carLeftSensor()
        {
            carPark.carEnteredCarPark();
            carOnSensor = false;
            return carOnSensor;
        }
    }
}