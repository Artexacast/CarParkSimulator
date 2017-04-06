using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces = 0;
        private int maxSpaces = 5;

        private void carArrivedAtEntrance()
        {
            EntrySensor sensor = new EntrySensor();
            sensor.carDetected();
        }

        private void TicketDispensed()
        {

        }

        private void carEnteredCarPark()
        {
            EntrySensor sensor = new EntrySensor();
            Barrier barrier = new Barrier();

            barrier.Lower();
            

            sensor.carLeftSensor();
        }

        private void carArrivedAtExit()
        {
            
            /////////////////////////////////////////////
            //Needs work/////////////////////////////////
            /////////////////////////////////////////////

          
        }

        public void ticketValidated()
        {
            Ticket ticket = new Ticket();
            ActiveTickets activeTicket = new ActiveTickets();
            if (ticket.isPaid() == true)
            {
                activeTicket.RemoveTicket();
            }
        }

        public void carExitedCarPark()
        {
            ExitSensor sensor = new ExitSensor();
            Barrier barrier = new Barrier();

            barrier.Lower();

            sensor.carLeftSensor();
        }

        public bool isFull()
        {
            FullSign sign = new FullSign();

            bool fullOrNot = false;
            if (currentSpaces < maxSpaces)
            {
                return fullOrNot;
            }
            else
            {
                bool stateToBeSetTo = true;
                sign.setLit(stateToBeSetTo);
                return fullOrNot = true;
            }
        }

        

    }
}
