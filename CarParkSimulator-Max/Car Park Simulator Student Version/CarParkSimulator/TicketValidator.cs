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
            if (validateTicket() == true)
            {
                activeTickets.RemoveTicket();
                carPark.ticketValidated();
                message = "Thankyou, drive safely.";
            }
            else
            {

            }
        }

        public bool validateTicket()
        {
            bool valid = false;
            if (activeTickets.GetTickets().Count != 0)
            {
                int lastTicket = activeTickets.GetTickets().Count() - 1;
                if (activeTickets.GetTickets()[lastTicket].isPaid() == true)
                {
                    return valid = true;

                }
                else
                {
                    message = "Please pay for your ticket and try again.";
                    return valid = false;
                    
                }
            }
            return valid;
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
