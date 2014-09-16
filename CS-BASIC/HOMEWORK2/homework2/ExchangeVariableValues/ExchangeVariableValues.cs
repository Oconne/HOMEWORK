using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = a; a = b; b = c;

            // b = a + b;
            // a = b - a;      a tricky way to exchange values
            // b = b - a;
          
            Console.WriteLine(""+a+"-"+b);

        }

       


    }
}
