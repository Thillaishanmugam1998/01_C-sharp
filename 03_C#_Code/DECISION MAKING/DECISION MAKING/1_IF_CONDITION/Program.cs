/* Syntax:
 * -------
 * if (bool_expression)
 * {
 *   Statements to exeute when the bool_expression is true:
 * }
 */

using System;
namespace _1_IF_STATEMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankBalance = 500000;

            if (bankBalance >= 500000)
            {
                Console.WriteLine("Get The Loan Upto 100000");
            }
            Console.WriteLine("Get out the condition");
        }
    }
}
