using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _13_StringTrim
    {
        #region String Trim()
        /*
         * In c#, the string Trim method is useful to remove all leading and trailing whitespace characters from the specified string object.
         * Using the Trim() method, we can also remove all occurrences of specified characters from the start and end of the current string.
         */
        #endregion

        #region SYNTAX:
        /*
         * public string Trim()
         * public string Trim(char[] trimChars)
         */
        #endregion

        //Trim Leading and tailing whitespace remove and trim char array
        public void StringTrimExample_1()
        {
            // Trim Whitespaces
            string str1 = " Welcome";
            string str2 = " to ";
            string str3 = " Tutlane";
            Console.WriteLine("Before Trim: {0} {1} {2}", str1, str2, str3);
            Console.WriteLine("After Trim: {0} {1} {2}", str1.Trim(), str2.Trim(), str3.Trim());
            char[] trimChars = { '*', '@', ' ' };
            // Trim with Characters
            string str4 = "@@** Suresh Dasari **@";
            Console.WriteLine("Before Trim: {0}", str4);
            Console.WriteLine("After Trim: {0}", str4.Trim(trimChars));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

        //remove only leading whitespace
        public void StringTrimExample_2()
        {
            // Trim Whitespaces
            string str1 = " Welcome";
            string str2 = " to ";
            string str3 = " Tutlane";
            Console.WriteLine("Before Trim: {0} {1} {2}", str1, str2, str3);
            Console.WriteLine("After Trim: {0} {1} {2}", str1.TrimStart(), str2.TrimStart(), str3.TrimStart());
            char[] trimChars = { '*', '@', ' ' };
            // Trim with Characters
            string str4 = "@@** Suresh Dasari **@";
            Console.WriteLine("Before Trim: {0}", str4);
            Console.WriteLine("After Trim: {0}", str4.TrimStart(trimChars));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

        //remove only tailing whitespace
        public void StringTrimExample_4()
        {
            // Trim Whitespaces
            string str1 = " Welcome ";
            string str2 = " to ";
            string str3 = " Tutlane ";
            Console.WriteLine("Before Trim: {0} {1} {2}", str1, str2, str3);
            Console.WriteLine("After Trim: {0} {1} {2}", str1.TrimEnd(), str2.TrimEnd(), str3.TrimEnd());
            char[] trimChars = { '*', '@', ' ' };
            // Trim with Characters
            string str4 = "@@** Suresh Dasari **@";
            Console.WriteLine("Before Trim: {0}", str4);
            Console.WriteLine("After Trim: {0}", str4.TrimEnd(trimChars));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
