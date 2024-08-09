using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _12_StringCopy
    {
        #region String Copy
        /*
         * In c#, the string Copy method is useful to create a new instance of a string object with the same content as the specified string object. 
         The copy method will return a string object that has the same value as the original string, but it represents a new object reference.

         * The main difference between the string clone() and copy() method is, 
         the copy method will create a new instance of a specified string object with the same content, 
         but the clone method will not create a new instance; instead, it will refer to an existing instance of the specified string object.
         */
        #endregion

        #region Syntax
        /*
         * public static string Copy(string str)
         */
        #endregion

        public void StringCopy()
        {
            string msg = "Welcome to Tutlane";
            string msg1 = string.Copy(msg);
            Console.WriteLine("String: {0}", msg);
            Console.WriteLine("Copy String: {0}", msg1);
            Console.WriteLine("Reference Equals: {0}", Object.ReferenceEquals(msg, msg1));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
