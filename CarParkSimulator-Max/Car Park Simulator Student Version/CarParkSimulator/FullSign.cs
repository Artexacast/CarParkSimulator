using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        public FullSign()
        {
            lit = false;
        }


        public bool isLit()
        {
            bool isSignLit = lit;
            return isSignLit;
        }

        public void setLit(bool stateToSetTo)
        {
            lit = stateToSetTo;
        }

        private bool lit;

    }
}
