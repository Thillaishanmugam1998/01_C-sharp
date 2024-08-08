using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _9_StringRemove
    {
        #region String Remove
        /*
         * In c#, the string Remove method is used to delete characters in the string starting from the specified position and continuing to the end of the string.
         * If we want to delete a particular length of substring, then we need to specify the starting position and length of characters to delete from the given string.
         */
        #endregion

        #region Syntax
        /*
         * public string Remove(int startIndex)
         * public string Remove(int startIndex, int length)
         */
        #endregion

        public void StringRemove()
        {
            string str = "Welcome to Thillai!";
            string newstring = str.Remove(7); //to Thillai
            string newstr = str.Remove(10, 17); //Thillai
        }
    }
}
