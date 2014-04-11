// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
// Print the variable values before and after the exchange.

namespace ExchangeVariableValues
{
    using System;

    class Swap
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.ReadLine();
        }
    }
}
