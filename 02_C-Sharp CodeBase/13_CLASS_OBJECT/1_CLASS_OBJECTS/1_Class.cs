﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_CLASS_OBJECTS
{
    class _1_Class_Object
    {
        #region CLASS:
        /*
         * In c#, Classes and Objects are interrelated. The class in c# is nothing but a collection of various data members (fields, properties, etc.) and member functions. 
         * The object in c# is an instance of a class to access the defined properties and methods.
         */
        #endregion

        #region DECLARING A CLASS:
        public class User
        {
            // Properties, Methods, Events, etc.
        }
        #endregion

        #region CLASS EXAMPLE:
        public class Users
        {
            //Fields
            public int id = 0;
            public string name = string.Empty;

            //Constructor
            public Users()
            {

            }

            //Function
            public void GetUserDetails(int Uid, string Uname)
            {
                id = Uid;
                name = Uname;
                Console.WriteLine("Id: {0}, Name: {1}", id, name);
            }

            //Properties
            public int Designation { get; set; }
            public string Location { get; set; }

        }
        #endregion

        #region CLASS MEMBERS
        /*
         *  a class can contain multiple data members in the c# programming language. 
         *  The following table lists different types of data members that can be used in c# classes.
         *  Fields	- Variables of the class.
            Methods	- Computations and actions that can be performed by the class.
            Properties	- Actions associated with reading and writing are named properties of the class.
            Events	- Notifications that can be generated by the class.
            Constructors	- Actions required to initialize instances of the class or the class itself.
            Operators- Conversions and expression operators are supported by the class.
            Constants- Constant values are associated with the class.
         */
        #endregion
    }
}
