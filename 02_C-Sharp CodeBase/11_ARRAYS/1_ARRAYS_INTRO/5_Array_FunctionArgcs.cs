/*
 * In c#, arrays are the reference types to pass arrays as arguments to the method parameters, 
 * and we can modify the values of array elements inside the method based on our requirements.
 * */
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ARRAYS_INTRO
{
    class _5_Array_FunctionArgcs
    {
        
        string[] str_arr   = new string[] {"Thillai","Tamizh","Vani"};
        string[,] str_arr2 = new string[2, 3] {
            {"Thillai","Tamizh","Tamizhillai"},
            {"Tamizhvani","Thillai","Tamizhillai"}
        };

        //1. C# Pass Single Dimensional Array as Argument
        public void methodwithsinglearray(string[] str_array)
        {
            for(int i=0; i<str_arr.Length;i++)
            {
                Console.WriteLine(str_array[i]);
            }
        }

        //2. C# pass Two Dimensional Array as Argument
        public void methodwithTwoArray(string[,] str_array2)
        {
            //str_array2.Length = 6
            //str_array2.GetLength(0) = 2
            //str_array2.GetLength(1) = 3
            for (int i=0; i<str_array2.GetLength(0);i++)    
            {
                for(int j=0; j<str_array2.GetLongLength(1);j++)
                {
                    Console.WriteLine(str_array2[i,j]);
                }
            }
        }

    }
}
