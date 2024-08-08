using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _12_STRING
{
    class _3_StringSplit
    {
        #region 1.String Split
        /*
         * In c#, the string Split method is used to split a string into substrings based on the array's characters. 
         * The split method will return a string array that contains a substring that is delimited by the specified characters in an array. 
         * 
         * Syntax:
         * --------
         * public string[] split(char[] separator)
         */
        #endregion

        //Example-1
        public void StringSplit1()
        {
            string str1 = "THILLAI-TAMIZH-TAMIZHILLAI";
            string[] arrstr = str1.Split('-');
            for (int i=0; i<arrstr.Length;i++)
            {
                Console.WriteLine(arrstr[i]);           
            }
            /* output
             * THILLAI
             * TAMIZHVANI
             * TAMIZHILLAI
             */
        }

        //Example-2
        public void StringSplit2()
        {
            string str1 = "THILLAI-TAMIZH,TAMIZHILLAI*TAMIZH";
            string[] arrstr = str1.Split(new char[] {'-','*',','},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arrstr.Length; i++)
            {
                Console.WriteLine(arrstr[i]);
            }
            /* output
             * THILLAI
             * TAMIZHVANI
             * TAMIZHILLAI
             * TAMIZH
             */
        }

    }
}
