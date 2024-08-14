using System;

namespace _6_STATIC_CLASS
{

    #region 1.STATIC CLASS:
    /*
     * In c#, a static class can be created by using static modifier and the static class can contain only static members.
     * Generally, the static class is same as the non-static class, but the only difference is the static class cannot be instantiated. Suppose if we apply static modifier to a class, 
     * we don't require to use the new keyword to create a class type variable.
     */
    #endregion

    #region 2.SYNRAX:
    /*
    static class sample
    {
        //static data members
        //static methods
    }
    */
    #endregion

    #region 3.EXAMPLE:
    static class User
    {
        // Static Variables
        public static string name;
        public static string location;
        public static int age;
        // Static Method
        public static void Details()
        {
            Console.WriteLine("Static Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User.name = "Suresh Dasari";
            User.location = "Hyderabad";
            User.age = 32;
            Console.WriteLine("Name: {0}", User.name);
            Console.WriteLine("Location: {0}", User.location);
            Console.WriteLine("Age: {0}", User.age);
            User.Details();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    #endregion

    #region 4.INFORMATION:
    /*
     * The static class in c# will contain only static members.
     * In c#, the static classes cannot be instantiated.
     * C# static classes are sealed, so they cannot be inherited.
     *The static classes in c# will not contain instance constructors.
     */
     #endregion
}


