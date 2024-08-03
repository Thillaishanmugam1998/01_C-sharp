using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ARRAYS_INTRO
{
    class _4_Array_Jagged
    {
        #region Jagged Array:
        /*
            * In c#, Jagged Array is an array whose elements are arrays with different dimensions and sizes. 
          Sometimes a jagged array is called an “array of arrays” and can store arrays 
          instead of a particular data type value.
         */
        #endregion

        //1. Jagged Array Declaration:
        public void JaggedArrayDeclaration()
        {
            #region Jagged Array Declaration:
            /*
             * In c#, a jagged array can be initialized with two square brackets [][]. 
             * The first square bracket will specify the size of an array, 
             * and the second one will specify the dimension of the array, which will be stored as a value.
             */
            #endregion

            //Jagged Array With Single Dimensional
            int[][] jarray = new int[2][];

            //Jagged Array With Two Dimensional
            int[][,] jarray2 = new int[2][,];
        }

        //2. Jagged Array Initiaization:
        public void JaggedArrayInitialization()
        {
            //Jagged Array with single dimensonal
            int[][] jarray_1 = new int[2][];  //It can store 2 one dimensonal array
            jarray_1[0] = new int[5] {1,2,3,4,5};
            jarray_1[1] = new int[5] {6,7,8,9,0};

            //Jagged Array With Two Dimensonal 
            int[][,] jarray_2 = new int[2][,];
            jarray_2[0] = new int[2, 2] { {1,2}, {3,4} };
            jarray_2[1] = new int[3, 5] { { 1, 2, 3, 4, 5 },{ 6, 7, 8, 9, 10 },{ 11, 12, 13, 14, 15 }, };

            //Jagged Array Initialization on Declaration
            int[][] jarray_3 = new int[][]
            {
                new int[5] {1,2,3,4,5},
                new int[2] { 1, 2 }
            };
        }

        //3. Jagged Array Example:
        public void JaggedArrayExample()
        {
            // Jagged Array with Single Dimensional Array
            int[][] jarray = new int[3][];
            jarray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[3] { 10, 20, 30 };
            jarray[2] = new int[] { 12, 50, 60, 70, 32 };
            Console.WriteLine("---Jagged Array with Single Dimensional Elements---\n");
            for (int i = 0; i < jarray.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write("{0}{1}", jarray[i][j], j == (jarray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            // Jagged Array with Two Dimensional Array
            int[][,] jarray1 = new int[2][,];
            jarray1[0] = new int[2, 2] { { 15, 24 }, { 43, 54 } };
            jarray1[1] = new int[,] { { 11, 12 }, { 13, 14 }, { 25, 26 } };
            Console.WriteLine("\n---Jagged Array with Mult-Dimensional Elements---\n");
            for (int i = 0; i < jarray1.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                for (int j = 0; j < jarray1[i].GetLength(0); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < jarray1[i].GetLength(1); k++)
                    {
                        Console.Write("{0}{1}", jarray1[i][j, k], k == (jarray1[i].GetLength(1) - 1) ? "" : " ");
                    }
                    Console.Write("{0}{1}", "}", j < jarray1.GetLength(0) ? ", " : "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    
}
