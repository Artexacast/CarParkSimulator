using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
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
            ticketList.RemoveAt(0);
        }
    }
}
