/*
 * n c#, params keyword is useful to specify a method parameter that takes a variable 
 * number of arguments. The params keyword is useful when we are not sure about
 * the number of arguments to send as a parameter.
 */

using System;

namespace _5_PARAM_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamMethod(1, 2, 3, 4, 5, 6);
            ParamMethod("Thillai", "Tamizh", 1701, 1404);
        }

        //METHOD-1:
        public static void ParamMethod(params int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

        //METHOD-2:
        //If you want to send a list of multiple types of arguments, then we need to use object
        //type parameter in the method declaration.
        public static void ParamMethod(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

    }
}
