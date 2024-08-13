using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CONSTRUCTOR
{
    class _3_StaticConstructor
    {
        #region STATIC CONSTRUCTOR:
        /*
         * In c#, Static Constructor is useful to perform a particular action only once throughout the application. 
         * If we declare a constructor as static, it will be invoked only once, irrespective of the number of class instances. 
         * It will be called automatically before the first instance is created.
         * Generally, in c# the static constructor will not accept any access modifiers and parameters. In simple words, we can say it’s parameterless.
        
         * The following are the properties of static constructor in the c# programming language.
            The static constructor in c# won’t accept any parameters and access modifiers.
            The static constructor will invoke automatically whenever we create the first instance of a class.
            CLR will invoke the static constructor, so we don’t have control over the static constructor execution order in c#.
            In c#, only one static constructor is allowed to create.
         */
        #endregion

        #region SYNTAX
        /*
         class User
        {
            // Static Constructor
            static User()
            {
               // Your Custom Code
            }
        }
         */
        #endregion

        #region EXAMPLE:
        class User
        {
            // Static Constructor
            static User()
            {
                Console.WriteLine("I am Static Constructor");
            }
            // Default Constructor
            public User()
            {
                Console.WriteLine("I am Default Constructor");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // Both Static and Default constructors will invoke for the first instance
                User user = new User();
                // Only the Default constructor will invoke
                User user1 = new User();
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }

        /*Output:
         * Iam a static constructor
         * Iam a default constructor
         * Iam a default constructor
         */
        #endregion
    }
}
