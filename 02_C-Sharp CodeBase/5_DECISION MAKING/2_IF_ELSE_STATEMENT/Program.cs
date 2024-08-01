/* syntac:
 * ------
 * if (bool_expression)
 * {
 *   statement execute when the bool_expression is true:
 * }
 * else
 * {
 *   statement execute when the bool_expression is false:
 *  }
 */
using System;

namespace _2_IF_ELSE_STATEMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            int loanAmount = 100000;

            if(loanAmount<=50000)
            {
                Console.WriteLine("Interest Per Year 25%");
            }
            else
            {
                Console.WriteLine("Interest Per Year 50%");
            }
        }
    }
}
