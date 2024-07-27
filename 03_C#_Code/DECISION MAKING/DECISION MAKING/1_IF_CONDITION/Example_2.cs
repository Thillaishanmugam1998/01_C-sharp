using System;
using System.Collections.Generic;
using System.Text;

namespace _1_IF_CONDITION
{
    class Example_2
    {
        public static void main (string[] args)
        {
            int bankBalance = 500000;

            if (bankBalance < 500000)
            {
                Console.WriteLine("Get Loan Upto 500000");
            }
            if (bankBalance >= 500000)
            {
                Console.WriteLine("Get Loan Upto 1000000");
            }
        }
    }
}
