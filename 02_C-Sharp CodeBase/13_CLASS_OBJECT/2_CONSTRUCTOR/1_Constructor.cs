using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CONSTRUCTOR
{
    class _1_Constructor
    {
        #region CONSTRUCTOR
        /*
         * In c#, Constructor is a method that will invoke automatically whenever an instance of class or struct is created. The constructor will have the same name as the class or struct, 
         * and it is useful to initialize and set default values for the data members of the new object.
         * If we create a class without any constructor, the compiler will automatically generate one default constructor for that class. 
         So, there is always one constructor that will exist in every class.
         * In c#, a class can contain more than one constructor with different types of arguments. 
         The constructors will never return anything, so we don’t need to use any return type, not even void while defining the constructor method in the class.
         */
        #endregion

        #region SYNTAX:
        /*
            public class User
            {
            // Constructor
            public User()
            {
            // Your Custom Code
            }
            }
         */
        #endregion

        #region TYPES OF CONSTRUCTOR:
        /*
         * C# Constructor Types
            In c#, we have different types of constructors available; those are
            Default Constructor
            Parameterized Constructor
            Copy Constructor
            Static Constructor
            Private Constructor
         */
        #endregion

        #region 1.DEFAULT CONSTRUCTOR:
        //In c#, if we create a constructor without any parameters, we will call it a default constructor.
        //Every instance of the class will be initialized without any parameter values.
        class User
        {
            public string name, location;
            // Default Constructor
            public User()
            {
                name = "Suresh Dasari";
                location = "Hyderabad";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // The constructor will be called automatically once the instance of the class created
                User user = new User();
                Console.WriteLine(user.name);
                Console.WriteLine(user.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion

        #region 2.PARAMETERIZED CONSTRUCTOR:
        //In c#, if we create a constructor with at least one parameter,
        //we will call it a parameterized constructor. Every instance of the class will be initialized with parameter values.

        class Users
        {
            public string name, location;
            // Parameterized Constructor
            public Users(string a, string b)
            {
                name = a;
                location = b;
            }
        }
        class Programs
        {
            static void Main(string[] args)
            {
                // The constructor will be called automatically once the instance of the class created
                Users user = new Users("Suresh Dasari", "Hyderabad");
                Console.WriteLine(user.name);
                Console.WriteLine(user.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion

        #region 3.CONSTRUCTOR OVERLOADING:
        //In c#, we can overload the constructor by creating another constructor with the same method name but with different parameters.
        class User_
        {
            public string name, location;
            // Default Constructor
            public User_()
            {
                name = "Suresh Dasari";
                location = "Hyderabad";
            }
            // Parameterized Constructor
            public User_(string a, string b)
            {
                name = a;
                location = b;
            }
        }
        class Program_
        {
            static void Main(string[] args)
            {
                User_ user = new User_(); // Default Constructor will be called
                User_ user1 = new User_("Rohini Alavala", "Guntur"); // Parameterized Constructor will be called
                Console.WriteLine(user.name + ", " + user.location);
                Console.WriteLine(user1.name + ", " + user1.location);
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion

        #region 4.CONSTRUCTOR CHAINING:
        //In c#, Constructor Chaining is an approach to invoke one constructor from another constructor. To achieve constructor chaining,
        //we need to use this keyword after our constructor definition.
        class User1
        {
            public User1()
            {
                Console.Write("Hi, ");
            }
            public User1(string a) : this()
            {
                Console.Write(a);
            }
            public User1(string a, string b) : this("welcome")
            {
                Console.Write(a + " " + b);
            }
        }
        class Program_1
        {
            static void Main(string[] args)
            {
                User1 user1 = new User1(" to", "tutlane");
                Console.WriteLine();
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        #endregion
    }
}
