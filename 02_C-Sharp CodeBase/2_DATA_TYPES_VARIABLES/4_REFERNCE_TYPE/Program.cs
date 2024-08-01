/*
 * In c#, Reference Types will contain a pointer that points to another memory location that holds the data. The Reference Types won’t store the variable value directly in its memory. Instead, 
   it will store the memory address of the variable value to indicate where the value is being stored.
 
 * For example, if we define and assign a value to the variable like string name = "Tamizh"; 
   then the system will store the variable value “Tamizh” in one location and 
   the variable "name" in another location along with the memory address of the variable value.
 
 * The following are the different data types that will fall under Reference Type in c# programming language.
    1.  String
    2.  Class
    3.  Delegates
    All Arrays, Even if their elements are value types
 */
using System;

namespace _4_REFERNCE_TYPE
{
    class Person
    {
        public int age;
    }
    class Program
    {
        /* 
        * Pass Reference Type by Value
        * -----------------------------
        *  In c#, if we pass a reference type variable from one method to another method, 
        the system won’t create a separate copy for that variable. Instead, 
        it passes the address of the variable, so if we make any changes to the variable in one method, 
        that also reflects in another method.
        */
        static void Square(Person a, Person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.age = 5;
            p2.age = 10;
            Console.WriteLine(p1.age + " " + p2.age);
            Square(p1, p2);
            Console.WriteLine(p1.age + " " + p2.age);
            Console.WriteLine("Press Any Key to Exit..");
            Console.ReadLine();
        }
    }
}
