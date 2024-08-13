using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CONSTRUCTOR
{
    class _2_CopyConstructor
    {
        #region Copy Constructor
        /*
         * In c#, Copy Constructor is a parameterized constructor that contains a parameter of the same class type. 
         * The copy constructor in c# is useful whenever we want to initialize a new instance to the values of an existing instance.
         */
        #endregion

        #region SYNTAX:
        /*
            class User
            {
                 // Parameterized Constructor
                 public User(string a, string b)
                 {
                     // your code
                 }
                 // Copy Constructor
                 public User(User user) {
                    // your code
                 }
            }
         */
        #endregion

        #region Example Copy Constructor
        class User
        {
            public string name, location;
            // Parameterized Constructor
            public User(string a, string b)
            {
                name = a;
                location = b;
            }
            // Copy Constructor
            public User(User user)
            {
                name = user.name;
                location = user.location;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // User object with a Parameterized constructor
                User user = new User("Suresh Dasari", "Hyderabad");
                // Another User object (user1) by copying user details
                User user1 = new User(user);
                user1.name = "Rohini Alavala";
                user1.location = "Guntur";
                Console.WriteLine(user.name + ", " + user.location);
                Console.WriteLine(user1.name + ", " + user1.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion
    }
}
