/*
 * In c#, we have two ways to allocate the space in memory, i.e., 
   either on stack or heap memory based on the Value Type or Reference Type parameters.
 */
using System;

namespace _3_VALUE_TYPE
{
    class Program
    {
        static void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            /*
             * C# Value Types
               In c#, a data type is a Value Type if it holds the value of the variable directly on its 
               own memory space, and Value Types will use Stack memory to store the values of the variables.

             * For example, if we define and assign a value to the variable like int x = 123; 
               then the system will use the same memory space of variable ‘x’ to store the value ‘123’.
            */

            //C# Pass Value Type by Value
            //In c#, if we pass a value type variable from one method to another method, the system will create a separate copy for the variable in another method.
            //If we make changes to the variable in one method, it won’t affect the variable in another method.
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
