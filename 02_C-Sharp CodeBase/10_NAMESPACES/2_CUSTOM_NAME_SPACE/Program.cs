using System;    //Access the Namespace By Using KeyWord
using CustomNameSpace;

namespace _2_CUSTOM_NAME_SPACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome w = new Welcome();
            w.GreetMessage();
            Console.WriteLine("Press Any Key to Exit..");
            Console.ReadLine();
        }
    }
}

namespace CustomNameSpace
{
    class Welcome
    {
        public void GreetMessage()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
    }
}