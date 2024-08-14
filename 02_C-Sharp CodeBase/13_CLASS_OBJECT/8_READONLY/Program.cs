using System;

namespace _8_READONLY
{
    #region 1.READONLY:
    /*
     * In c#, readonly is a keyword, and it is useful to define read-only fields in our applications. 
       The read-only field values need to be initialized either at the declaration or in a constructor of the same class, 
       unlike the constant keyword in c#. If we use readonly keyword with fields, those field values will evaluate at the runtime.
     * To define read-only fields in c#, we need to use readonly keyword during the declaration of fields in our application, 
       and we can use readonly modifier with the numbers, boolean values, strings, or null references.
     * In c#, if we use readonly keyword to define the read-only field, 
       that field value cannot change once the constructor execution has finished, 
       so we should not use readonly keyword with the fields whose value will change at any time.
     */
    #endregion

    #region 2.SYNTAX:
    //  readonly data_type field_name = "value";

    
    class Users
    {
        // Initialize Read Only Fields
        public readonly string name = "Suresh Dasari";
        public readonly string location;
        public readonly int age;
        public Users()
        {
            location = "Hyderabad";
            age = 32;
        }
        public void SetDetails()
        {
            // Compile error if uncommented
            //location = "Guntur";
            //age = 30;
        }
    }
    #endregion

    #region 3.EXAMPLE:
    class User
    {
        // Initialize Read Only Fields
        public readonly string name = "Suresh Dasari";
        public readonly string location;
        public readonly int age;
        public User()
        {
            location = "Hyderabad";
            age = 32;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // This will throw compile time error
            //u.name = "Rohini Alavala";
            Console.WriteLine("Name: {0}", u.name);
            Console.WriteLine("Location: {0}", u.location);
            Console.WriteLine("Age: {0}", u.age);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    #endregion

    #region 4.INFORMATION:
    /*
     * In c#, we can create the Read-only fields using readonly keyword.
     * In c#, you can initialize the readonly fields either at the declaration or in a constructor.
     * The readonly field values will evaluate during the run time in c#.
     * Once values assign to the read-only fields, those values must be the same throughout the application.
     */
    #endregion

    #region 5.CONST VS READONLY:
    /*
     * In c#, you can create the constant fields using const keyword and the read-only fields created by using readonly keyword.
     * In c#, the constant fields are initialized during the declaration, but the read-only fields are initialized either at the declaration or in a constructor.
     * The constant field values are evaluated during the compile-time, but the read-only field values are evaluated at run time in c#.
     */
    #endregion

}
