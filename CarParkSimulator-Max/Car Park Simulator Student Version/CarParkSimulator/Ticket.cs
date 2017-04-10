using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        Random rand = new Random();

        public Ticket()
        {
            ticketNumber = rand.Next(90000, 100000);
            paid = false;
        }

        public bool isPaid()
        {
            return paid;
        }

        public bool setPaid(bool paidOrNot)
        {
            paid = paidOrNot;
            return paid;
        }

        public string getName()
        {
            return Convert.ToString(ticketNumber);
        }

        private bool paid;

        private int ticketNumber;
       
        
      
    }
}
