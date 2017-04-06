using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        private void Lower()
        {
            lifted = false;
        }

        private void Raise()
        {
            lifted = true;
        }

        private bool IsLifted()
        {
            bool isLifted = lifted;
            return isLifted;
        }

        private bool lifted;
        public bool Lifted
        {
          get { return lifted; }
          set { lifted = value; }
        }}

}