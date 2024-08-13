using System;

namespace _3_DECONSTRUCTOR
{
    #region 1.DECONSTRUCTOR:
    /*
     * In c#, Destructor is a special method of a class, and it is used in a class to destroy the object or instances of classes. 
     * The destructor in c# will invoke automatically whenever the class instances become unreachable.

      Following are the properties of destructor in c# programming language.

     * In c#, destructors can be used only in classes, and a class can contain only one destructor.
     * The destructor in class can be represented by using the tilde (~) operator
     * The destructor in c# won’t accept any parameters and access modifiers.
     * The destructor will invoke automatically whenever an instance of a class is no longer needed.
     * The garbage collector automatically invokes the destructor whenever the class objects are no longer needed in the application.
     */
    #endregion

    #region 2.SYNTAX:
    /*
    class User
    {
        // Destructor
        ~User()
        {
            // your code
        }
    }
    */
    #endregion

    #region 3.EXAMPLE:
    class User
    {
        public User()
        {
            Console.WriteLine("An Instance of class created");
        }
        // Destructor
        ~User()
        {
            Console.WriteLine("An Instance of class destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details();
            GC.Collect();
            Console.ReadLine();
        }
        public static void Details()
        {
            // Created instance of the class
            User user = new User();
        }
    }
    #endregion
}