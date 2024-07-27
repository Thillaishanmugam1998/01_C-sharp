/*
 * Syntax:
 * -----
    switch(variable/expression){
    case value1:
    // Statements to Execute
    break;
    case value2:
    //Statements to Execute
    break;
    ....
    ....
    default:
    // Statements to Execute if No Case Matches
    break;
    }
*/
using System;

namespace _7_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            switch (x)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("No Matching Case Found");
                    break;
            }
        }
    }
}
