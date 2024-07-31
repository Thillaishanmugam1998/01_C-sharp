/*
 * In c#, out keyword is used to pass arguments to the method as a reference type. 
 * The out keyword same as the ref keyword, but the only difference is out doesn’t 
 * require a variable to be initialized before we pass it as an argument to the method. 
 * Still, the variable must be initialized 
 * in called method before it returns a value to the calling method.
 * SYNTAX
 * -------
 *  int x; // No need to initialize the variable
    Multiplication(out x);

    If you observe the above declaration, we just declared a variable x and passed it to the 
    method using out parameter without assigning any value. Still, as discussed, the variable must be initialized 
    in called method before it returns a value to the calling method.
 */
using System;

namespace _4_OUT_PARAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Multiplication(out x);
            Console.WriteLine("Variable Value: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

            int a, b;
            Multiplication(out a, out b);
            Console.WriteLine("Variable Value: {0} {1}", a,b);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

        }
        //Single Out Param
        public static void Multiplication(out int a)
        {
            a = 10;
            a *= a;
        }
        //Multi out param
        public static void Multiplication(out int x, out int y)
        {
            x = 100;
            y = 500;
        }

    }
}