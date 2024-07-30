/* Syntax:
 * --------
 * do
 * {
 *   Statement to execute
 * } while(boolean_expression);
 */
using System;

namespace _3_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("i value is: {0}", i);
                i++;
                int j = 0;
                do
                {
                    if (j == 1)
                        break; 
                    
                    Console.WriteLine("j value is: {0}", j);
                    j++;
                } while (j<=5);
            } while (i <= 5);
        }
    }
}
