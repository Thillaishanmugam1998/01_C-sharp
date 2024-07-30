using System;

namespace _4_RETURN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 14;
            int number2 = 17;
            int result;
            result = sum(number1, number2);
            Console.WriteLine("Sum Of Value Is:{0}", result);
        }

        public static int sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
