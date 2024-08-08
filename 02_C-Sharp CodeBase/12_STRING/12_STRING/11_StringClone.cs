using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _11_StringClone
    {

        #region String Clone
        /*
         In c#, the string Clone method is used to clone and return a copy of the specified string object. 
         The return value of the clone method is not an independent copy of the specified string because the clone method will return an existing string instance.
         */
        #endregion

        #region Syntax
        /*
         * public object Clone()
         */
        #endregion
        
        public void StringClone()
        {
            string msg = "Welcome to Tutlane";
            object msgo = msg.Clone();
            string msg1 = (string)msgo;
            Console.WriteLine("String: {0}", msg);
            Console.WriteLine("Clone String: {0}", msg1);
            Console.WriteLine("Reference Equals: {0}", Object.ReferenceEquals(msg, msg1));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

            //Here we used a ReferenceEquals method to check whether the original and cloned string objects are referring to the same instance or not.
        }
    }
}
