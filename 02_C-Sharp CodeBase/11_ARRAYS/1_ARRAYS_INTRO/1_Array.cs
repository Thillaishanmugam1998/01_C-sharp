/*  C# Arrays with Examples:
 *  ------------------------
 *  In c#, Arrays are useful for storing multiple elements of the same data type at contiguous memory locations. 
    It will store a fixed number of elements sequentially based on the predefined number of items.
 * 
 * An array can start storing the values from index 0. 
   If we have an array with n elements, it will start storing the elements from index 0 to n-1.
 */
using System;

namespace _1_ARRAYS_INTRO
{
    class _1_Array
    {
        //1. Array Declaration
        public void ArrayDeclaration()
        {
            // Syntax: type_data[] arr_name;
            #region Array Declaration:
            /*
              In c#, the array elements can be of any type, and by default,
              the values of numeric array elements are set to zero, and the reference elements are set to null.
             */
            #endregion

            //Store Int values only
            int[] arr_int;
            //Store String values only
            string[] arr_string;
            //Store Float values only
            float[] arr_float;
            //Store Double values only
            double[] arr_double;

        }
        
        //2.Array Initialization
        public void ArrayInitialization()
        {
            #region Array Initialization:
            /*
             In c#, Arrays can be initialized by creating an instance of the array with a new keyword. Using a new keyword, 
             we can declare and initialize an array simultaneously based on our requirements.
            */
            #endregion

            //  1.  Declaring and Initialization Array with size of 5
            int[] arr_int = new int[5];
            //  2.  Declaring and Initialization Array and Assign values at same time
            int[] arr_int_2 = new int[5] { 1, 2, 3, 4, 5 };
            //  3.  Initialize with 5 elements will indicate the size of an array
            int[] arr_int_3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  4.  Another way to initialize an array without the size
            int[] arr_int_4 = { 1, 2, 3, 4, 5 };
            //  5.  Declare an array without initialization
            int[] arr_int_5;
            arr_int_5 = new int[] { 1, 2, 3, 4, 5 };
            //  6.  Initialization array element using index
            int[] arr_int_6 = new int[2];
            arr_int_6[0] = 1;
            arr_int_6[1] = 2;

            #region Array Without Size and New Keyword throw compile-time Error:
            /*
            // Error. Initialize an array without size
            int[] array = new int[];
            // Error. Initialize an array without a new keyword
            int[] array1;
            array1 = { 1, 2, 3, 4, 5 };
            */
            #endregion
        }

        //3.Array Element Accessing
        //In c#, we can access array elements using for loop or foreach loop or with particular index numbers.
        public void ArrayElementAccessByIndex()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Index [0]: {0}", arr1[0]);
            Console.WriteLine("Index [1]: {0}", arr1[1]);
            Console.WriteLine("Index [2]: {0}", arr1[2]);
            Console.WriteLine("Index [3]: {0}", arr1[3]);
            Console.WriteLine("Index [4]: {0}", arr1[4]);
            Console.ReadLine();
        }

        //3.1.Array Element Accessing By For Loop:
        public void ArrayElementAccessByForLoop()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();
        }

        //3.2.Array Element Accessing By For Each Loop:
        public void ArrayElementAccessByForEachLoop()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int number in arr1)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
