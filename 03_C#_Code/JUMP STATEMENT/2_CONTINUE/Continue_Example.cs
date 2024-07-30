using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CONTINUE
{
    class Continue_Example
    {
        //Continue with For Loop
        public void ContinueWithForLoop()
        {
            for(int i=0; i<=5;i++)
            {
                if (i == 0)
                    continue;
                Console.WriteLine("I value is:{0}", i);
            }
        }

        public void ContinueWithWhile()
        {
            int i = 0;
            while(i<=5)
            {
                i++;
                if (i == 1)
                    continue;
                Console.WriteLine("I value is: {0}",i);
            }
        }
        public void ContinueWithDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine("I value is: {0}", i);
                i++;
                if (i == 1)
                    continue;
            } while (i <= 5);
        }
    }
}
