using System;
using System.Collections.Generic;
using System.Text;

namespace _12_STRING
{
    class _15_StringFormat
    {
        #region StringFormat
        /*
         * In c#, the string Format method is used to insert the variable's value or an object or expression into another string. Using the string Format method, we can replace the format items in the specified string with the string representation of specified objects.
         */
        #endregion

        #region SYNTAX:
        /*
         * public string Format(string, object)
         * public string Format(string, object, object)
         * public string Format(IFormatProvider, string, object)
        */
        #endregion

        #region FORMAT:
        /* 
            0	Zero Placeholder	{0:00.00}	75674.74
            #	Digit Placeholder	{0:(#).##}	(75674).74
            .	Decimal Point	{0:0.000}	75674.738
            ,	Thousand Separator	{0:0,0}	75,675
            %	Percent	{0:0%}	7567474%

            c	Currency	{0:c}	$ 75,674.74
            e	Scientific	{0:e}	7.567474e+004
            f	Fixed Point	{0:f}	75674.74
            g	General	{0:g}	75674.73789621
            n	Thousand Separator	{0:n}	75,674.74
            d	Short Date	{0:d}	29-05-2018
            D	Long Date	{0:D}	29 May 2018
            t	Short Time	{0:t}	05:29:20
            T	Long Time	{0:T}	05:29:20
            f or F	Long Date Time	{0:f}	29 May 2018 05:30:08
            g or G	Short Date Time	{0:g}	29-05-2018 05:31:42
            M	Short Date	{0:M}	May 29
            r	RFC1123 Date Time String	{0:r}	Tue, 29 May 2018 05:33:02 GMT
            s	Sortable Date/Time	{0:s}	2018-05-29T05:34:10
            u	Universal Sortable Date	{0:u}	2018-05-29 05:35:47Z
            U	Universal full date	{0:U}	29 May 2018 00:08:07
            Y	Year month pattern	{0:Y}	May, 2018


         */
        #endregion

        public void StringFormat1()
        {
            string s = "Name:{0} {1}, Location:{2}, Age:{3}";
            string msg = string.Format(s, "Suresh", "Dasari", "Hyderabad", 32);
            Console.WriteLine("Format Result: {0}", msg);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();


            decimal num = 75.73789621m;
            DateTime datetime = DateTime.Now;
            Console.WriteLine("Format Decimal: {0:n2}", num);
            Console.WriteLine("DateTime: {0}", datetime);
            Console.WriteLine("Only Date: {0:D}", datetime);
            Console.WriteLine("Only Time: {0:T}", datetime);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
