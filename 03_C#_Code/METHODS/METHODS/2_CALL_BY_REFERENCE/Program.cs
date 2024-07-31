/*
 * In c#, passing a value type parameter to a method by reference means passing a 
 * reference of the variable to the method. So the changes made to the parameter 
 * inside the called method will affect the original data stored in the argument 
 * variable.
 * 
 * Using the ref keyword, we can pass parameters reference-type. 
 * It’s mandatory to initialize the variable value before passing it as an argument
 * to the method in the c# programming language.
 * 
 *  int x = 10; // Variable need to be initialized
 *  Multiplication(ref x);
 * If you observe the above declaration, we declared and assigned a value to the 
 * variable x before passing it as an argument to the method by using a reference 
 * (ref).

 * To use the ref parameter in the c# application, both the method definition and 
 * the calling method must explicitly use the ref keyword.
 * */


using System;

namespace _2_CALL_BY_REFERENCE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
            Multiplication(ref x);
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

        }

        public static void Multiplication(ref int a)
        {
            a *= a;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }
    }
}
