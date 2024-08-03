using System;

namespace _1_ARRAYS_INTRO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str_arr = new string[] { "Thillai", "Tamizh", "Vani" };
            string[,] str_arr2 = new string[2, 3] {
            {"Thillai","Tamizh","Tamizhillai"},
            {"Tamizhvani","Thillai","Tamizhillai"}
        };

            _5_Array_FunctionArgcs arr_obj = new _5_Array_FunctionArgcs();
            arr_obj.methodwithTwoArray(str_arr2);
        }
    }
}
