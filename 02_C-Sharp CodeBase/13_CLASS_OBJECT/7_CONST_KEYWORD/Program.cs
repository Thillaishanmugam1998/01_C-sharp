using System;

namespace _7_CONST_KEYWORD
{

    #region 1.CONST:
    /*
     * In c#, const is a keyword, and it is helpful to declare constant fields in our applications. 
     * Generally, in c#, constant field values are set at compile-time, and those values will never change.
     * In c#, if we use const keyword to declare a constant field, that field value will not change throughout the application, 
     * so we should not use const keyword with the fields whose value will change at any time.
     * */
    #endregion

    #region 2.SYNTAX:
    // const data_type field_name = "value";

    //// Constant variables
    // const string name = "Suresh Dasari";
    // const string location = "Hyderabad";
    // const int age = 32;
    #endregion

    #region 3.EXAMPLE:
    class Program
    {
        static void Main(string[] args)
        {
            // Constant variables
            const string name = "Suresh Dasari";
            const string location = "Hyderabad";
            const int age = 32;
            // This will throw compile-time error
            //name = "Rohini Alavala";
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    #endregion

    #region 4.INFORMATION:
    /*
     * In c#, we can create the constant fields using const keyword.
     * In c#, the constant fields must initialize during the time of declaration.
     * In c#, the constant field values will evaluate during the compile time.
     * Once values are assigned to constant fields, those values must be the same throughout the application
     */
    #endregion

}
