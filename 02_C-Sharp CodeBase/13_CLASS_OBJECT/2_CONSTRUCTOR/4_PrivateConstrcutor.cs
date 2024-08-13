using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CONSTRUCTOR
{
    class _4_PrivateConstrcutor
    {
        #region PRIVATE CONSTRUCTOR:
        /*
         * In c#, Private Constructor is a special instance constructor, and it is useful in classes that contain only static members. 
         * If a class contains one or more private constructors and no public constructors, then the other classes are not allowed 
         * to create an instance for that particular class except nested classes.
         */
        #endregion

        #region SYNTAX:
        /*
            class User
            {
               // Private Constructor
               private User()
               {
                   // Your Custom Code
               }
            }
         */
        #endregion

        #region EXAMPLE:
        class User
        {
            // Private Constructor
            private User()
            {
                Console.WriteLine("I am Private Constructor");
            }
            public static string name, location;
            // Default Constructor
            public User(string a, string b)
            {
                name = a;
                location = b;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // The following comment line will throw an error because the constructor is inaccessible
                //User user = new User();

                // Only the Default constructor with parameters will invoke
                User user1 = new User("Suresh Dasari", "Hyderabad");
                Console.WriteLine(User.name + ", " + User.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion
    }
}
