/* 
 * Syntax:
 * ------
 *  condition_expression? first_expression : second_expression; 
 */

using System;

namespace _6_TERNARY_OPERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;

            //If condition
            if (x>=y)
            {
                Console.WriteLine("X is greater then Y");
            }
            else
            {
                Console.WriteLine("Y is greater then X");
            }

            //Ternary Operator
            string result;
            result = (x > y) ? "X is greater then Y" : "Y is greater then X";
            Console.WriteLine(result);

            //Nested Ternary Operator
            result = (x==y)? "X and Y is Equal": (x > y) ? "X is greater then Y" : "Y is greater then X";
            Console.WriteLine(result);
        }
    }
}
