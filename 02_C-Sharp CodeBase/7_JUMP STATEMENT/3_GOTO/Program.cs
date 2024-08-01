/* the Goto statement is used to transfer program control to the defined labeled statement, 
 * and it is useful to get out of the loop 
 * or exit from deeply nested loops based on our requirements.
 * ------------SYNTAX:-----------------
 * goto labeled_statement;
 */

using System;

namespace _3_GOTO
{
    class Program
    {
        static void Main(string[] args)
        {
            GotoExample GE = new GotoExample();
            GE.GotoWithForLoop();
            GE.GotoWithWhile();
            GE.GotoWithSwitchCase();
        }
    }
}
