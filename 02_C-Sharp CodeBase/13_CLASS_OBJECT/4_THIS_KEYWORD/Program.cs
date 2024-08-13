using System;

namespace _4_THIS_KEYWORD
{
    #region 1.THIS KEYWORD:
    /*
     * In c#, this keyword is used to refer to the current instance of a class, and by using this keyword, 
     * we can pass a current instance of the class as a parameter to the other methods.
     * In case the class contains parameters and variables with the same name, 
     * then this keyword is useful to distinguish between the parameters and variables.
     * In c#, we should not use this keyword to refer to static fields or methods. 
     * In the same way, it cannot be used in static classes
     */
    #endregion

    #region 2.SYNTAX:
    // this.instance_variable
    #endregion

    #region 3.EXAMPLE
    class User
    {
        public string name, location;
        public long marks = 470;
        public User(string name, string location)
        {
            // Use this to distinguish between parameters and variables
            this.name = name;
            this.location = location;
        }
        public void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
            // Passing a class instance to the method using this
            Console.WriteLine("Marks: {0}", Exams.GetPercentage(this));
        }
    }
    class Exams
    {
        public static double GetPercentage(User u)
        {
            double i = ((double)470 / 600) * 100;
            return (i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Suresh Dasari", "Hyderabad");
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    #endregion
}
