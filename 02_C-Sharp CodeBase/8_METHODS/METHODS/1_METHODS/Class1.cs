using System;
using System.Collections.Generic;
using System.Text;

namespace _1_METHODS
{
    class Class1
    {
        //With parameter and with return.
        public string GetUsername(string username)
        {
            return username;
        }

        //Without Param and With Return.
        public string GetPassword()
        {
            return "Admin@123";
        }

        //With Param and Without Return.
        public void GetUserinfo(string username, string password)
        {
            Console.WriteLine("Username:{0}, Password:{1}",username,password);
        }
    }
}
