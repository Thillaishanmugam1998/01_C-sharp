using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _8_StringCompre
    {
        #region String Compare
        /*
         * In c#, the string Compare method is used to compare two specified strings and return an integer value 
         * that indicates their relative position in the sort order.
         */
        #endregion

        #region Syntax
        /*
         * public int Compare(string string1, string string2)
         * If two strings are equal then return 0
         * If string1 is greather then string2 then return 1
         * if string1 is lessthen string2 then return -1
         */
        #endregion

        public void StringCompareExample()
        {
            string s1 = "ABCD";
            string s2 = "abcd";

            int result = string.Compare(s1, s2);   //-1

            /*
             * Comparison of ABCD and abcd Result: -1
                Unicode values:
                s1: A = 65, B = 66, C = 67, D = 68
                s2: a = 97, b = 98, c = 99, d = 100
            */

            string s3 = "aA";
            string s4 = "Aa";
            int result2 = string.Compare(s3, s4);
            
            /*
                If the first differing character in the first string is greater than the corresponding character in the second string, 
                the result is positive (typically 1), and if it is less, the result is negative (typically -1). 
                The comparison does not proceed to subsequent characters once a difference has been determined.
             */

        }
    }
}
