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
            message = "Please insert your ticket.";
        }

        public void ticketEntered()
        {
            activeTickets.RemoveTicket();
            carPark.ticketValidated();
            message = "Thankyou, drive safely.";

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
