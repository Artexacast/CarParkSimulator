using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator 
{
    class ExitSensor : Sensor
    {
        CarPark carpark;

        public ExitSensor(CarPark carPark)
        {
            this.carpark = carPark;
            carOnSensor = false;
        }

        public override bool carDetected()
        {
            carpark.carArrivedAtExit();
            carOnSensor = true;
            return carOnSensor;
        }

        public override bool carLeftSensor()
        {
            carpark.carExitedCarPark();
            
            carOnSensor = false;
            return carOnSensor;
        }
    }
}
