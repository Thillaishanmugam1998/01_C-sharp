using System;
using System.Collections.Generic;
using System.Text;

namespace _1_ARRAYS_INTRO
{
    class _2_Array_Class
    {
        #region Array Class:
        /*
           * In c#, we have a class called Array, and it will act as a base class for all the arrays in the common language runtime (CLR). 
             The Array class provides methods for creating, manipulating, searching, and sorting arrays.
            
           * For example, by using the Sort or Copy methods of the Array class, 
            we can sort the elements of an array and copy the elements of one array to another based on our requirements. 
         */
        #endregion

        //1.Array.Copy:
        public void ArrayCopy()
        {
            int[] source_arr      = new int[5] { 5, 2, 4, 1, 3 };
            int[] destination_arr = new int[5];
            Array.Copy(source_arr, destination_arr, source_arr.Length);
            foreach (int i in destination_arr)
            {
                Console.WriteLine(i);    //5,2,4,1,3
            }
        }

        //2.Array.Reverse:
        public void ArrayReverse()
        {
            int[] source_arr = new int[5] { 5, 2, 4, 1, 3 };
            Array.Reverse(source_arr);
            foreach (int i in source_arr)
            {
                Console.WriteLine(i);    //3,1,4,2,5
            }
        }

        //3. Array.Sort
        public void ArraySort()
        {
            int[] numbers = { 5, 3, 8, 1, 2 };
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Output: 1 2 3 5 8
            }
        }

        //4. Array.IndexOf
        public void ArrayIndexOf()
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
            int index = Array.IndexOf(fruits, "Cherry");
            Console.WriteLine(index); // Output: 2
        }

        //5. Array.Clear
        public void ArrayClear()
        {
            // Sets a range of elements in the array to the default value of each element type.
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Clear(numbers, 1, 2);

            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Output: 1 0 0 4 5
            }

        }

        //6. Array.Resize
        public void ArrayResize()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array.Resize(ref numbers, 7);

            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Output: 1 2 3 4 5 0 0
            }
        }

        //7. Array.Find
        public void ArrayFind()
        {
            // Searches for an element that matches the conditions defined by a specified predicate
            // and returns the first occurrence.
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = Array.Find(numbers, n => n > 3);
            Console.WriteLine(result); // Output: 4
        }

        //8. Array.Exists
        public void ArrayExists()
        {
            // Determines whether the array contains elements that match the conditions
            // defined by a specified predicate.

            int[] numbers = { 1, 2, 3, 4, 5 };
            bool exists = Array.Exists(numbers, n => n > 3);
            Console.WriteLine(exists); // Output: True
        }
    }
}
