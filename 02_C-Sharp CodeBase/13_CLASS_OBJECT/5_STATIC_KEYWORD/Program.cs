using System;

namespace _5_STATIC_KEYWORD
{
    #region 1.STATIC KEYWORD:
    /*
     * In c#, static is a keyword or a modifier that is useful to make a class or methods or variable properties, 
     * not instantiable which means we cannot instantiate the items which we declared with a static modifier.
     * The static members which we declared can be accessed directly with a type name. Suppose if we apply a static modifier to a class property or a method or variable, 
     * we can access those static members directly with a class name instead of creating an object of a class to access those properties.
     */
    #endregion

    #region 2.SYNTAX:
    /*
     
     class User
     {
       public static string name, location;
       public static int age;
     }

    * If you observe the above example, we defined variables with static keyword, and we can access those 
    * variables directly with a type name like User.name or User.location and User.age.
    
    Console.WriteLine(User.name);
    Console.WriteLine(User.location);
    Console.WriteLine(User.age);

    Generally, in c# the instance of a class will contain a separate copy of all instance fields so that the memory consumption will increase automatically, 
    but if we use static modifier, there is only one copy of each field, so automatically, 
    the memory will be managed efficiently.
     */
    #endregion

    #region 3.EXAMPLE:
    class User
    {
        // Static Variables
        public static string name, location;
        //Non-Static Variable
        public int age;
        //Non-Static Method
        public void Details()
        {
            Console.WriteLine("Non Static Method");
        }
        // Static Method
        public static void Details1()
        {
            Console.WriteLine("Static Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.age = 32;
            u.Details();
            User.name = "Suresh Dasari";
            User.location = "Hyderabad";
            Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, User.location, u.age);
            User.Details1();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    #endregion
    
}
