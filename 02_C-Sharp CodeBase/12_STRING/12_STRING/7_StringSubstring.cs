using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _7_StringSubstring
    {
        #region SubString
        /*
         * In c#, the Substring method is useful to get a substring from the given string. 
         * The substring starts from the specified character position and continues to the end of the string.
         */
        #endregion

        #region Syntax:
        /*
         * public string Substring(int startIndex)
         * public string Substring(int startIndex, int length)
         */
        #endregion

        //Example
        public void SubstringMethod()
        {
            string msg = "Welcome to Tutlane";
            Console.WriteLine("SubString: {0}", msg.Substring(5));
            Console.WriteLine("Substring with Length: {0}", msg.Substring(3, 7));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
