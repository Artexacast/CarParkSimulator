using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private ActiveTickets activeTickets;

        private CarPark carPark;

        public TicketValidator(ActiveTickets activeTickets)
        {
            this.activeTickets = activeTickets;
        }

        private string message;

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void carArrived()
        {
            message = "Car has arrived at the exit.";
        }

        public void ticketEntered()
        {
            //needs to remove ticket
            carPark.ticketValidated();
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
