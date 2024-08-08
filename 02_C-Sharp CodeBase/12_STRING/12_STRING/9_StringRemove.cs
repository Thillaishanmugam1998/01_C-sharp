using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _10_StringEquals
    {
        #region String Equals
        /*
         * In c#, the string Equals method is used to check whether the specified two string objects have the same value or not. 
         * If both string object values are equal, then the Equals() method will return true otherwise false.
         * If both string objects have a null value, then the string Equals() method will return true.
         */
        #endregion

        #region Syntax
        /*
         * public bool Equals(string a, string b)
         */
        #endregion

        public void StringEquals()
        {
            string fname = "Suresh";
            string lname = "Dasari";
            Console.WriteLine("{0} Equals to {1}? : {2}", fname, lname, fname.Equals(lname));
            string l_name = "suresh";
            Console.WriteLine("{0} Equals to {1}? : {2}", fname, l_name, fname.Equals(l_name));
            string u_name = "Suresh";
            Console.WriteLine("{0} Equals to {1}? : {2}", fname, u_name, fname.Equals(u_name));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
            

            Console.WriteLine("{0} Equals to {1}? : {2}", fname, l_name, fname.Equals(l_name, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("{0} Equals to {1}? : {2}", fname, u_name, fname.Equals(u_name));
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
