// 2. Data Types

/* When a value type is converted to object type, it is called boxing and on the other hand, 
when an object type is converted to a value type, it is called unboxing.

object obj;
obj = 100; // this is boxing
*/

using System;

namespace DataTypeApplication {
   class Program {
      static void Main(string[] args) {
        int x = 10;
         Console.WriteLine("Size of int: {0}", sizeof(x));
         Console.ReadLine();
      }
   }
}