/* 
 * In c#, Passing a Value-Type parameter to a method by value means passing a copy of the variable 
 * to the method. So the changes made to the parameter inside the called method will not affect 
 * the original data stored in the argument variable.
 */

using System;

namespace _3_PASS_BY_VALUE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
            Multiplication(x);
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        public static void Multiplication(int a)
        {
            a = 1000;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }
    }
}
