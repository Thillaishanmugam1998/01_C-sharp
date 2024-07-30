/* Syntax:
 * ------
 * while(boolen_expression)
 * {
 *      Statement to execute
 * }
 */
using System;

namespace _2_WHILE_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 4)
            {
                Console.WriteLine("i value: {0}", i);
                i++;
                int j = 1;
                while (j < 2)
                {
                    Console.WriteLine("j value: {0}", j);
                    j++;
                }
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}

