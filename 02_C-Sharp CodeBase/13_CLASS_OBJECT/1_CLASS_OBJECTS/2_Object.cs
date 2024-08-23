using System;
using System.Collections.Generic;
using System.Text;

namespace _1_CLASS_OBJECTS
{
    class _2_Object
    {
        #region OBJECT:
        /*
         * In c#, Object is an instance of a class that can be used to access the data members and member functions of a class.
         */
        #endregion

        //Creating Objects in C#
        /*
         * Users user = new Users();
         */

        #region Example
        class Program
        {
            static void Main(string[] args)
            {
                Users user = new Users("Suresh Dasari", 30);
                user.GetUserDetails();
                Console.WriteLine("Press Enter Key to Exit..");
                Console.ReadLine();
            }
        }
        public class Users
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Users(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void GetUserDetails()
            {
                Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
            }
        }
        #endregion
    }
}
