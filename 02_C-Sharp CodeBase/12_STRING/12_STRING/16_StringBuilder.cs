using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _16_StringBuilder
    {
        #region StringBuilder
        /*
         * In c#, StringBuilder is a class that is useful to represent a mutable string of characters, and it is an object of the System.Text namespace.
         * Like string in c#, we can use a StringBuilder to create variables to hold any text, a sequential collection of characters based on our requirements.
         * In c#, both string and StringBuilder will represent a sequence of characters and perform the same kind of operations, 
            but the only difference is strings are immutable, and StringBuilder is mutable.
         * Generally, in c# the string object cannot be modified once it is created. 
            If any changes are made to the string object, like adding or modifying an existing value, it will simply discard the old instance in memory and create a new instance to hold the new value. If we are doing repeated modifications on the string object, it will affect the application's performance. 
            To solve this problem, c# introduced an alternative called StringBuilder, 
            which is a mutable string class. Mutability means once an instance of the class is created, 
            then the same instance will be used to perform any operations like inserting, appending, removing, or replacing the characters instead of creating a new instance every time.
         */
        #endregion


        #region StringBuilderMethods:
        /*
            StringBuilder.Append	This method will append the given string value to the end of the current StringBuilder.
            StringBuilder.AppendFormat	It will replace a format specifier passed in a string with formatted text.
            StringBuilder.Insert	It inserts a string at the specified index of the current StringBuilder.
            StringBuilder.Remove	It removes a specified number of characters from the current StringBuilder.
            StringBuilder.Replace	It replaces a specified character at a specified index.
         */
        #endregion

        public void StringBuilder()
        {
            //The Append method is used to add or append a string object at the end of the string represented by the StringBuilder
            StringBuilder sb = new StringBuilder("Suresh");
            sb.Append(", Rohini");
            sb.Append(", Trishika");
            Console.WriteLine(sb);
            // Output: Suresh, Rohini, Trishika

            //The AppendFormat method is used to add or append string objects by formatting them into a specified format at the end of the string represented by the StringBuilder.
            int amount = 146;
            StringBuilder sb1 = new StringBuilder("Total");
            sb.AppendFormat(": {0:c}", amount);
            Console.WriteLine(sb1);
            // Output is Total: $146.00

            //The Insert method is used to insert a string at the specified index position of the current StringBuilder object.
            StringBuilder sb3 = new StringBuilder("Welcome Tutlane");
            sb.Insert(8, "to ");
            Console.WriteLine(sb3);
            // Output: Welcome to Tutlane

            //The Remove method is used to remove a specified number of characters from the current StringBuilder object, starting from the specified index position.
            StringBuilder sb4 = new StringBuilder("Welcome to Tutlane");
            sb.Remove(8, 3);
            Console.WriteLine(sb4);
            // Output: Welcome Tutlane

            //The Replace method is used to replace all occurrences of specified string characters in the current StringBuilder object with a specified replacement string character
            StringBuilder sb5 = new StringBuilder("Welcome to Tutlane");
            sb.Replace("Tutlane", "C#");
            Console.WriteLine(sb5);
            // Output: Welcome to C#
        }
    }
}
