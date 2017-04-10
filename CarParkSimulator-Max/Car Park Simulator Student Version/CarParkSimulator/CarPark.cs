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

        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
        private FullSign fullSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier;



        public CarPark(TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
        }

        public void carArrivedAtEntrance()
        {
            ticketMachine.carArrived();
            
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void carEnteredCarPark()
        {
            currentSpaces++;

            entryBarrier.Lower();

            if(currentSpaces >= maxSpaces)
            {
                fullSign.setLit(true); //turns on sign
            }

            ticketMachine.clearMessage();
        }

        public void carArrivedAtExit()
        {
            ticketValidator.carArrived();
        }

        public void ticketValidated()
        {
            exitBarrier.Raise(); 
        }

        public void carExitedCarPark()
        {
            currentSpaces--;
            exitBarrier.Lower();
            if (fullSign.isLit() == true)
            {
                fullSign.setLit(false);
            }

            ticketValidator.clearMessage();
        }

        public bool isFull()
        {

            bool full = false;

            if (currentSpaces < maxSpaces)
            {
                return full;
            }
            else
            {
                full = true;
                fullSign.setLit(full);
                return full;
            }

        }

        public bool isEmpty()
        {
            bool empty = false;

            if (currentSpaces == 0)
            {
                empty = true;
            }

            return empty;
        }

        public bool hasSpace()
        {
            bool space = false;

            if (currentSpaces < maxSpaces)
            {
                space = true;
            }

            return space;
        }

       public int getCurrentSpaces()
       {
           return currentSpaces;
       }

        

    }
}
