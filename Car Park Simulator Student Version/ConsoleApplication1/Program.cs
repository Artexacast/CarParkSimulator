using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            e.num = -67538934;
            e.SetNum(123);
        }
    }

    class Example
    {
        private int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (value < 0 || n > 100)
                {
                    //. errororor
                }
                else
                {
                    num = n;
                }
            }
        }

        public void SetNum(int value)
        {
            if (value < 0 || value > 100)
            {
                //. errororor
            }
            else
            {
                num = value;
            }
        }

        // syntactic sugar
    }
}
