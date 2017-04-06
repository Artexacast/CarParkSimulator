using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        public void FullSign()
        {
            Lit = false;
        }

        public bool isLit()
        {
            bool isSignLit = Lit;
            return isSignLit;
        }

        public void setLit(bool stateToSetTo)
        {
            Lit = stateToSetTo;
        }

        private bool lit;

        public bool Lit
        {
            get { return lit; }
            set { lit = value; }
        }

    }
}
