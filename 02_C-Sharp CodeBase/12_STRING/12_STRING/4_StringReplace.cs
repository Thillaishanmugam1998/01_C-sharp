using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _4_StringReplace
    {
        #region StringReplace
        /*
         * In c#, the string Replace method is used to replace a specified string or a character in all occurrences of the given string.
         * The replace method will return a new string after replacing all occurrences of a specified string or a character.
         * Syntax:
         * -------
         * public string Replace(char oldchar, char newchar)
         * public string Replace(string oldstring, string newstring)
         */
        #endregion

        //Example-1
        public void StringReplace()
        {
            string OldStr = "HI THILLAI HI";
            string newStr = OldStr.Replace("HI", "WELCOME");
            Console.WriteLine("Old: {0}", OldStr);    //HI THILLAI HI
            Console.WriteLine("New: {0}", newStr);    //WELCOME THILLAI WELCOME

            string oldstr = "aaaaa";
            string newstr = oldstr.Replace('a', 'b').Replace('b', 'c');
            Console.WriteLine("Old: {0}", oldstr);    //aaaaa
            Console.WriteLine("New: {0}", newstr);    //ccccc

        } 
    }
}
