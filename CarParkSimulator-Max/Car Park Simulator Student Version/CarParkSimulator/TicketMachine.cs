using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private CarPark carPark;
        ActiveTickets activetickets;

        public TicketMachine(ActiveTickets activeTickets)
        {
            message = " ";
            this.activetickets = activeTickets;
        }

        private string message;

        public void AssignCarPark(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public void carArrived()
        {
            message = "Press button for ticket.";
            
        }

        public void printTicket()
        {
            activetickets.AddTicket();
            carPark.TicketDispensed();
            message = "Please enjoy your stay.";
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
