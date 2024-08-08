using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _6_StringContains
    {
        #region String Contains
        /*
         * In c#, the string Contains method is used to check whether the specified substring exists in the given string or not, and it will return a boolean value.
         * If a substring exists in a string, then the contains method will return true otherwise, it will return false.
         * Syntax:
         * ------
         * public bool Contains(string value)
         */
        #endregion

        //Example-1
        public void StringContains1()
        {
            string str1 = "Thillai Shanmugam Welcome";
            string str2 = "Welcome";
            bool result = str1.Contains(str2);
            Console.WriteLine("Result:" + result);
        }

        //Example-2
        public void StringContains2()
        {
            string msg = "Welcome to Tutlane";
            string subtxt = "Tutlane";
            Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt));
            string subtxt1 = "tutlane";
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            bool result = msg.IndexOf(subtxt1, comp) > 0 ? true : false;
            Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt1, result);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
