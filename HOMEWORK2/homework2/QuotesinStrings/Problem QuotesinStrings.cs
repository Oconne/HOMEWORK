using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotesinStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstQuotes = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(firstQuotes);

            string secondQuotes = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(secondQuotes);
            Console.ReadLine();
        }
    }
}
