using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ARRAYS_INTRO
{
    class _3_Array_Type
    {
        #region Array Types:
        /*
         * C# Array Types
            In c#, we have different types of arrays available; those are
                1.  Single-Dimensional Arrays
                2.  Multi-Dimensional Arrays
                3.  Jagged Arrays
        */

        //2.MultiDimensonal Array:
        // In c#, a multidimensional array is an array that contains more than one dimension to
        //represent the elements in a tabular format like rows and columns.
        // In c#, multidimensional arrays can support either two or three-dimensional series.
        //To create multi-dimensional arrays, we need to use a comma (,) separator inside the square brackets.

        #endregion

        //2.1. C# Multi-Dimensional Array Declaration
        public void MultiDimensioanlArrayDeclaration()
        {
            // One dimensional array
            int[] onearr = new int[5];

            // Two dimensional array
            int[,] twoarr = new int[4, 2];

            // Three dimeonsional array
            int[,,] threearr = new int[4, 2, 3];

            //If you observe the above examples, we created a two-dimensional array (twoarr) with 4 rows, 2 columns,
            //and another array (threearr) with three dimensions 4, 2, 3.
        }

        //2,2, C# Multi-Dimensional Array Initialization
        public void MultiDimensionalArrayInitialization()
        {
            //Two dimensional array  (3 - ROW, 2- COLOUMN)
            int[,] arr_two = new int[3, 2] { 
                { 1, 2 },
                { 3, 4 },
                { 5, 6 } 
            };  

            //Two dimensional array
            int[,] arrtwo = new int[,] {
                {1,2,3,4,5},
                {6,7,8,9,10}
            };

            //Three dimensional array  (2 - Array Inside, 2-ROW, 3-COLOUMN)
            int[,,] arr_three = new int[2,2,3] {
                {
                    {1,2,3 },
                    {4,5,6 }
                },
                {
                    {7,8,9 },
                    {10,11,12 }
                }
            };

            //Three dimensional arry without size
            int[,,] three_arr_ = new int[,,] {
                {
                    {1,2},
                    {3,4}
                },
                {
                    {5,6},
                    {7,8}
                }, 
            };
        }

        //2,3. C# Access Multidimensional Array Elements
        public void MultiDimensionalArrayAccess()
        {
            // Two Dimensional Array
            int[,] arr2D = new int[3, 2] {
                               { 4, 5 },        //00 01
                               { 5, 0 },        //10 11
                               { 3, 1 }         //20 21
                             };
            // Three Dimensional Array
            int[,,] array3D = new int[2, 2, 3] {
                                     { { 1, 2, 3 }, { 4, 5, 6 } },
                                     { { 7, 8, 9 }, { 10, 11, 12 } }
                                  };
            Console.WriteLine(arr2D[1, 0]); // 5
            Console.WriteLine(array3D[1, 1, 1]); // 11
        }

        //2.4. C# Access MultiDimensional Array Example:
        public void Example()
        {
            // Two Dimensional Array
            int[,] array2D = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };
            // Three Dimensional Array
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine("---Two Dimensional Array Elements---");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D[i, j]);
                }
            }
            Console.WriteLine("---Three Dimensional Array Elements---");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);
                    }
                }
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    
}
