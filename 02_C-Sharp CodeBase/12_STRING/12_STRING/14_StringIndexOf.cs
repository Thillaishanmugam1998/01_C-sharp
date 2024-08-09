using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _14_StringIndexOf
    {
        #region String IndexOf:
        /*
         * In c#, the string IndexOf method is useful to return an index of the first occurrence of the specified character in the given string.
         * Generally, in c# the string IndexOf method will start searching for the specified character starting from the Zero position and return the first occurrence of the specified character in the given string.
         * If you want to change the specified character search starting position and to examine the only specified number of character positions in a string, then we can do it by specifying the required start position 
           and the number of character positions to search in the string IndexOf method.
         */
        #endregion

        #region SYNTAX:
        /*
         * public int IndexOf(char ch)
         * public int IndexOf(char ch, int startIndex)
         * public int IndexOf(char ch, int startIndex, int count)
         * public int IndexOf(char ch, StringComparison comparisonType)
         * public int IndexOf(string str)
         * public int IndexOf(string str, int startIndex)
         * public int IndexOf(string str, int startIndex, int count)
         * public int IndexOf(string str, StringComparison comparisonType)
         */
        #endregion


        public void StringIndexOf_1()
        {
            string name = "Suresh Dasari";
            Console.WriteLine("Character s Index Position: {0}", name.IndexOf("s"));
            Console.WriteLine("Ignore Case: {0}", name.IndexOf("s", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Change Search Start Position: {0}", name.IndexOf("s", 5));
            Console.WriteLine("Characters Length Reult: {0}", name.IndexOf("s", 5, 3));
            Console.WriteLine("String Position: {0}", name.IndexOf("Dasa"));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
