using System;
using System.Collections.Generic;
using System.Text;

namespace _1_BREAK
{
    class BreakExample
    {
        public void BreakWithForLoop()
        {
            for(int i=0; i<=5;i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("i value is: {0}", i);
            }
        }
        public void BreakWithDoWhile()
        {
            int i = 0;
            do
            {
                if (i == 5)
                    break;
                Console.WriteLine("i value is: {0}", i);
                i++;
            } while (i <= 5);
        }
        public void BreakWithWhile()
        {
            int i = 0;
            while(i<=5)
            {
                if (i == 5)
                   break;
                Console.WriteLine("i value is: {0}", i);
                i++;
            }
        }

    }
}
