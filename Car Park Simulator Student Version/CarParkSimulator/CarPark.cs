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
            entryBarrier.Lower();
            if(currentSpaces >= maxSpaces)
            {
                fullSign.setLit(true); //turns on sign
            }
        }

        public void carArrivedAtExit()
        {
            ticketValidator.carArrived();
        }

        public void ticketValidated()
        {
            ticketValidator.ticketEntered();
            exitBarrier.Raise(); 

        }

        public void carExitedCarPark()
        {
            exitBarrier.Lower();
        }

        public bool isFull()
        {
            bool fullOrNot = false;
            if (currentSpaces < maxSpaces)
            {
                return fullOrNot;
            }
            else
            {
                bool stateToBeSetTo = true;
                fullSign.setLit(stateToBeSetTo);
                return fullOrNot = true;
            }
        }

        public bool isEmpty()
        {
            bool emptyOrNot = false;

            if (currentSpaces == 0)
            {
                emptyOrNot = true;
            }

            return emptyOrNot;
        }

        public bool hasSpace()
        {
            bool spaceOrNot = false;

            if (currentSpaces < maxSpaces)
            {
                spaceOrNot = true;
            }

            return spaceOrNot;
        }

       public int getCurrentSpaces()
       {
           return currentSpaces;
       }

        

    }
}
