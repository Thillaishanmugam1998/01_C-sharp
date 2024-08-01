/* Syntax:
 * ------
 * foreach (Type var_name in Collection_Object) 
 * {
 *   Statements to Execute
 * }
 */

using System;

namespace _4_FOR_EACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3] { "Thillai", "Tamizh", "Tamizhillai" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
