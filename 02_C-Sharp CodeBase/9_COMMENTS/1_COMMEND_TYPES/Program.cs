/*
 * Single-line Comments
 * Multi-line Comments
 * XML Comments
*/

using System;

namespace _1_COMMEND_TYPES
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Single line comments
            Console.WriteLine("Single Line Comment");

            /* 2. Mutliline Comments
               This is Multiline Comments
             */
            Console.WriteLine("Multiline Comment");
        }
        //3. XML Comments
        /* In c#, XML Comments are a special type of comments, 
         * and these will be added above the definition of 
         * any user-defined type or member.
         * In c#, the XML Comments are defined by using /// (triple forward slashes) 
         * and with XML formatted comment body.
         */

        /// <summary>
        /// This is a XML Comments
        /// </summary>
        /// <param name="Message"></param>
        public static void MessageInfo(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
