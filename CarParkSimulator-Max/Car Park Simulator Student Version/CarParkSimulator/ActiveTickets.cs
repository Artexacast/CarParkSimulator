using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        Random rand = new Random();

        

        protected List<Ticket> ticketList = new List<Ticket>();

        public List<Ticket> GetTickets()
        {
            return ticketList;
        }

        public void AddTicket()
        {
            Ticket ticket = new Ticket();
            ticketList.Add(ticket);
        }

        public void RemoveTicket()
        {
            if (ticketList.Count() == 0)
            { 
                ticketList.Remove(ticketList[ticketList.Count()]); 
            }
            else
            {
                ticketList.Remove(ticketList[ticketList.Count() - 1]);
            }
        }
    }
}
