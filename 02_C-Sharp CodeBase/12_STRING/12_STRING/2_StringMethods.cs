using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _2_StringMethods
    {
        #region StringMethods:
        /*
            * Clone()	It returns a reference to this instance of String.
            * Compare(String, String)	It compares two specified String objects and returns an integer that indicates their relative position in the sort order.
            * Concat(String, String)	It concatenates two specified instances of String.
            * Contains(String)	It returns a value indicating whether a specified substring occurs within this string.
            * Copy(String)	It creates a new instance of a String with the same value as a specified String.
            * Format(String, Object)	It replaces one or more format items in a specified string with the string representation of a specified object.
            * Trim()	It removes all leading and trailing white-space characters from the current String object.
            * ToLower()	It converts a given string to a lowercase.
            * ToUpper()	It converts a given string to uppercase.
            * Split(Char[])	It splits a string into substrings that are based on the characters in an array.
            * Substring(Int32)	It retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
         */
        #endregion

        public void StringMethods()
        {
            // Length
            string str = "Hello, World!";
            int length = str.Length;
            Console.WriteLine($"Length: {length}");  // Output: Length: 13

            // ToUpper and ToLower
            string upperStr = str.ToUpper();
            string lowerStr = str.ToLower();
            Console.WriteLine($"Upper: {upperStr}");  // Output: Upper: HELLO, WORLD!
            Console.WriteLine($"Lower: {lowerStr}");  // Output: Lower: hello, world!

            // Substring
            string subStr = str.Substring(7, 5);
            Console.WriteLine($"Substring: {subStr}");  // Output: Substring: World

            // IndexOf and LastIndexOf
            int index = str.IndexOf('o');
            int lastIndex = str.LastIndexOf('o');
            Console.WriteLine($"IndexOf: {index}");      // Output: IndexOf: 4
            Console.WriteLine($"LastIndexOf: {lastIndex}");  // Output: LastIndexOf: 8

            // Contains
            bool contains = str.Contains("World");
            Console.WriteLine($"Contains 'World': {contains}");  // Output: Contains 'World': True

            // Replace
            string replacedStr = str.Replace("World", "C#");
            Console.WriteLine($"Replace: {replacedStr}");  // Output: Replace: Hello, C#!

            // Split
            string[] words = str.Split(',');
            foreach (string word in words)
            {
                Console.WriteLine($"Word: {word.Trim()}");
            }
            // Output:
            // Word: Hello
            // Word: World!

            // Trim
            string strWithSpaces = "   Hello, World!   ";
            string trimmedStr = strWithSpaces.Trim();
            Console.WriteLine($"Trimmed: '{trimmedStr}'");  // Output: Trimmed: 'Hello, World!'

            // StartsWith and EndsWith
            bool startsWith = str.StartsWith("Hello");
            bool endsWith = str.EndsWith("World!");
            Console.WriteLine($"StartsWith 'Hello': {startsWith}");  // Output: StartsWith 'Hello': True
            Console.WriteLine($"EndsWith 'World!': {endsWith}");  // Output: EndsWith 'World!': True

            // Join
            string[] wordsToJoin = { "Hello", "World", "C#" };
            string joinedStr = string.Join(", ", wordsToJoin);
            Console.WriteLine($"Join: {joinedStr}");  // Output: Join: Hello, World, C#

            // Compare
            string str1 = "Hello";
            string str2 = "hello";
            int comparison = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Compare: {comparison}");  // Output: Compare: 0 (because we are ignoring case)

            // Format
            string name = "John";
            int age = 30;
            string formattedStr = string.Format("Name: {0}, Age: {1}", name, age);
            Console.WriteLine(formattedStr);  // Output: Name: John, Age: 30

            // Copy
            string originalStr = "Original";
            string copiedStr = string.Copy(originalStr);
            Console.WriteLine($"Original: {originalStr}, Copied: {copiedStr}");  // Output: Original: Original, Copied: Original

            // Clone
            string clonedStr = (string)originalStr.Clone();
            Console.WriteLine($"Cloned: {clonedStr}");  // Output: Cloned: Original

            // ReferenceEquals
            bool referenceEquals = Object.ReferenceEquals(originalStr, copiedStr);
            Console.WriteLine($"ReferenceEquals (Original, Copied): {referenceEquals}");  // Output: ReferenceEquals (Original, Copied): False

            referenceEquals = Object.ReferenceEquals(originalStr, clonedStr);
            Console.WriteLine($"ReferenceEquals (Original, Cloned): {referenceEquals}");  // Output: ReferenceEquals (Original, Cloned): True

            // Case-insensitive comparison
            string caseInsensitiveStr1 = "hello";
            string caseInsensitiveStr2 = "HELLO";
            bool equalsIgnoreCase = string.Equals(caseInsensitiveStr1, caseInsensitiveStr2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Case-insensitive Equals: {equalsIgnoreCase}");  // Output: Case-insensitive Equals: True
        }
    }
}
