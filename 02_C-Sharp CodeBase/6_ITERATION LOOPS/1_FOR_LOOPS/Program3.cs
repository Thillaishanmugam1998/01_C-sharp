/* Syntax:
 * ------
 * for (initialization; condition; iterator(inc / dec))
 * {
 *  Statements To Execute
 * }
 */

using System;

namespace _1_FOR_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop with Break Statement
            int i = 0;
            for (; i<=4; i++)
            {
                if (i==3)
                  break;
                Console.WriteLine("I Value: {0}", i);
            }

            //Nested For Loop:
            for(i=0;i<=5;i++)
            {
                for(int j=0;j<=5;j++)
                {
                    Console.WriteLine("i value is: {0} and j value is: {1}", i, j);
                }
            }
            
            //Infinite Loop:
            //for (; ;)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Press the key to exit");
            Console.ReadLine();
        }
    }
}
