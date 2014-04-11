// Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
// Try to add some number or the null literal to these variables and print the result.

namespace NullValuesArithmetic
{
    using System;

    class NullValues
    {
        static void Main()
        {
            int? i = 0;
            double? d = 0.0;

            Console.WriteLine(i);
            Console.WriteLine(d);

            i = null;
            d = null;
            Console.WriteLine(i);
            Console.WriteLine(d);
        }
    }
}
