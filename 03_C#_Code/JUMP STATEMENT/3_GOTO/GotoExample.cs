using System;
using System.Collections.Generic;
using System.Text;

namespace _3_GOTO
{
    class GotoExample
    {
        //Goto With ForLoop
        public void GotoWithForLoop()
        {
            int i = 0;
            for(;i<=5;i++)
            {
                if (i == 5)
                    goto endloop;
                Console.WriteLine("I Value Is: {0}", i);
            }
            endloop: Console.WriteLine("End The Loop");
            Console.WriteLine("After the Goto Statement");
        }

        //Goto With While
        public void GotoWithWhile()
        {
            int i = 0;
            while(i<=5)
            {
                if (i == 4)
                    goto endloop;
                Console.WriteLine("Before Goto Statement");
                i++;
            }
        endloop: Console.WriteLine("EndLoop");
        }

        //Goto WithSwitch Case
        public void GotoWithSwitchCase()
        {
            int i = 1;
            switch(i)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    goto case 2;
                    
                case 2:
                    Console.WriteLine("Case 2");
                    goto case 3;
                    
                case 3:
                    Console.WriteLine("Jump from case 1 to case 3 using goto statement");
                    break;
                default:
                    break;
            }
        }
    }
}
