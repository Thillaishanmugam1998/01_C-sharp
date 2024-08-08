using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _5_StringConcat
    {
        #region String Concat
        /*
         * In c#, the string Concat method is used to concatenate or append one string to the end of another string and return a new string.
         * Syntax:
         * ------
         * public string Concat(string string1, string string2)
         */
        #endregion

        //Example-1
        public void StringConcat1()
        {
            string str1 = "Thillai";
            string str2 = "," + " "+"Shanmugam";
            Console.WriteLine("String-1: {0}", str1); //THILLAI
            Console.WriteLine("String-2: {1}", str2); //, SHANMUGAM

            string str3 = string.Concat(str1, str2); //THILLAI, SHANMUGAM

            string str4 = ","+" TAMIZHVANI";
            string str5 = ","+" TAMIZHILLAI";
            string str6 = string.Concat(string.Concat(str4, str5), str3); //THILLAI, SHANMUGAM, TAMIZHVANI, "TAMIZHILLAI

        }
    }
}
