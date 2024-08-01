using System;

namespace _4_NESTED_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 46;

            if(age>=18)
            {
                if(age<=40)
                {
                    Console.WriteLine("Upto 10Lac Loan Elegible");
                }
                else if (age<=50)
                {
                    Console.WriteLine("Upto 5Lac Loan Elegible");
                }
            }
            else if (age<18)
            {
                if(age<=15)
                {
                    Console.WriteLine("Your are not elegible for loan");
                }
                else if (age<18)
                {
                    Console.WriteLine("Next year you will elegible for loan");
                }
            }
        }
    }
}
