/* Syntax:
 * ------
 * if (condition_1)
    {
    // Statements to Execute if condition_1 is True
    }
    else if (condition_2)
    {
    // Statements to Execute if condition_2 is True
    }
    else if (condition_3)
    {
    // Statements to Execute if condition_3 is True
    }
    ....
    ....
    else{
    // Statements to Execute if all conditions are False
    }
*/

using System;

namespace _3_IF_ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 50;
            int number2 = 100;

            if(number1 == number2)
            {
                Console.WriteLine("Number1 and Number2 is Same");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Number1 is Greaterthen Number2");
            }
            else
            {
                Console.WriteLine("Number1 is Lessthen Number2");
            }
        }
    }
}
