/* Generally, methods are useful to improve code reusability by reducing code duplication. 
 * If we have the same functionality to perform in multiple places, then we can 
 * create one method with the required functionality and use it wherever it is required in the 
 * application.
 * ------------------SYNTAX--------------------
 * class class_name
{
    ...
    ...
    <Access_Specifier> <Return_Type> Method_Name()
    {
        // Statements to Execute
    }
    ...
    ...
}
*/
using System;

namespace _1_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without Static Methods:
            Class1 obj = new Class1();
            string username = obj.GetUsername("Tamizh");
            Console.WriteLine("Username:{0}", username);

            //With Static Methods:
            string result = Program.GetUserInfo("Tamizh", "Tazmizh@1701");
            Console.WriteLine("Result: {0}", result);
        }

        //If we create methods with static,
        //then we can directly invoke those methods from the class level without creating an object
        public static string GetUserInfo(string username,string password)
        {
            string info = string.Format("Username:{0},Password:{1}",username,password);
            return info;
        }
    }
}
