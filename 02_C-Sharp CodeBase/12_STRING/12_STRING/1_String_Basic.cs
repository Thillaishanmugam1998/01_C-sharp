/*
 * C# String with Examples
 * -----------------------
 * In c#, the string is a keyword that is useful to represent a sequential collection of characters called a text, 
 * and the string is an object of the System.String type
 */

using System;

namespace _12_STRING
{
    class _1_String_Basic
    {
        //1. String Declaration and Initialization:
        public void StringDeclarationAndInitialization()
        {
            //Declare a string without initialization
            string str1;
            //Declare a string with initialization
            string str2 = "THILLAI";
            string str3 = "TAMIZHVANI";   //Dont use 'TAMIZHVANI' bcz consider single quotes as char
            //Declare a string with Empty string.
            string str4 = string.Empty;
            //Decalre a string with null
            string str5 = null;
            //Declare a string from char array
            char[] char_arr = new char[] { 'T', 'A', 'M', 'I', 'Z', 'H' };
            String str6 = new string(char_arr);
            //String 
            String str7 = "TAMIZHILLAI";
        }

        #region String Vs string:
        /* 2. String vs string
         * -------------------
         * In c#, the string keyword is just an alias for String, so both string and String are equivalent, 
         and you can use whichever naming convention you prefer to define string variables.
         */
        #endregion

        #region String Immutable:
        /*
         * In c#, the string is immutable,
           which means the string object cannot be modified once it is created. 
           If any changes are made to the string object, like adding or modifying an existing value, 
           it will simply discard the old instance in memory and create a new instance to hold the new value.
           For example, when we create a new string variable “msg” with the text “welcome”, 
           a new instance will create a heap memory to hold this value. 
           Now, if we make any changes to the msg variable, like changing the text from “welcome” to “welcome to tutlane”, 
           then the old instance on heap memory will be discarded, 
           and another instance will create on heap memory to hold the variable value instead of modifying the old instance in the memory.
         * In c#, if we perform modifications like inserting, concatenating, removing, or replacing a value of the existing 
           string multiple times, every time the new instance will create on heap memory to hold the new value, 
           so automatically the performance of the application will be affected.
         */
        #endregion

        //2. String Literals in REGULAR
        public void stringLiteralsRegular()
        {
            /*
             * In c#, the string literal is a sequence of characters enclosed in double quotation marks (" "). 
             * We have two kinds of string literals available in c#; those are regular and verbatim. The regular literals are useful when we want to embed escape characters like \n, \t, \', \", etc. in c#.
             */

            string names = "THILLAI\nTAMILZH\nTAMIZHILLAI";
            Console.WriteLine(names);
            /*
             output:
             THILLAI
             TAMIZH
             TAMIZHILLAI
            */

            string msg = "Hello \"WORLD\" ";
            Console.WriteLine(msg);
            // Output: Hello "WORLD"

        }

        //2.1. String Literals in Verbatim
        public void stringLiteralsVerbatim()
        {
            /*
             * In c#, the special character @ will serve as verbatim literal, 
             * and it is useful to represent a multiline string or a string with backslash characters,
             */

            string imagepath = @"C:\Users\Thillai\TAMIL.jpg";
            Console.WriteLine(imagepath);  //C:\Users\Thillai\TAMIL.jpg

            string msg = @"THIS,
            IS STRING VERBATIM
            FORMAT";
            Console.WriteLine(msg);

            /*output:
             THIS,
             IS STRING VERBATIM
             FORMAT
            */

            string msg2 = @"MY daughter name was ""TAMIZHILLAI"" ";
            Console.WriteLine(msg2);   //Output: MY daughter name was "TAMIZHILLAI"
        }

        //3. String Format
        public void stringFormat()
        {
            /*
             * In c#, the format string is a string whose contents can be determined dynamically at runtime. 
             * We can create a format string using the Format method and embedding placeholders in braces that will be replaced by other values at runtime.
             */

            string name = "Thillai Shanmugam";
            string location = "Kumbakonam";
            string user = string.Format("Name: {0}, Location: {1}", name, location);
            Console.WriteLine(user);
            // Output: Name: Thillai Shanmugam, Location: Kumbakonam
        }

        //4.Access individual Character From strings
        public void AccessString()
        {
            string name = "Thillai Shanmugam";
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            // Output: Thillai Shanmugam
        }

        //5.String Properties
        /*
         * Chars  - It helps us to get the characters from the current string object based on the specified position. 
         * Length - It returns the number of characters in the current String object.
         */
    }
}
