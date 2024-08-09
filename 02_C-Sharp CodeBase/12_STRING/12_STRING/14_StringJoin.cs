using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _14_StringJoin
    {
        #region String Join()
        /*
         * In c#, the string Join method is used to concatenate all the elements of the string array using a specified separator between each element.
         */
        #endregion

        #region SYNTAX:
        /*
         *  public static string Join(string separator, params string[] values)
            public static string Join(string separator, params object[] values)
            public static string Join(string separator, IEnumerable values)
        */
        #endregion

        
        //Example-1
        public void StringJoin1()
        {
            string[] sArr = { "Welcome", "to", "Tutlane" };
            Console.WriteLine("Join with Hypen: {0}", string.Join("-", sArr));
            string[] sArr1 = { "Suresh", "Rohini", "Trishika" };
            Console.WriteLine("Join with Comma: {0}", string.Join(", ", sArr1));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
