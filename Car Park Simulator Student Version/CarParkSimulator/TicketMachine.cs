using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private CarPark carPark;

        public TicketMachine(ActiveTickets activeTickets)
        {
            message = " ";
        }

        private string message;

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void carArrived()
        {
            message = "Car has arrived at the entrance.";
            
        }

        public void printTicket()
        {
            carPark.TicketDispensed();
        }

        public void clearMessage()
        {
            message = " ";
        }

        public string getMessage()
        {
            return message;
        }
    }
}
