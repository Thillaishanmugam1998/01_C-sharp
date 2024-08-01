/*
 * In c#, Variables will represent storage locations, and each variable has a particular type that determines 
 * what type of values can be stored in the variable.
 * --------------------------------------------------
 * Syntax:
 * --------------------------------------------------
    [Data Type] [Variable Name];
    [Data Type] [Variable Name] = [Value];
    [Access Specifier] [Data Type] [Variable Name] = [Value];
 */
using System;

namespace _2_VARIABLES
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string name = "Tamizh";
            double percentage = 10.23;
            char gender = 'F';
            bool isVerified = true;
            Console.WriteLine("Id: " + number);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Percentage: " + percentage); Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Verified: " + isVerified);
            Console.ReadLine();
        }
    }
}
