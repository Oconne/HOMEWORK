using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersinIntervalDividablebyGivenNumber
{
    class NumbersinIntervalDividablebyGivenNumber
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int k=0;
            for (int i = n1; i <= n2; i++) { if (i % 5 == 0) { k++;} }

            Console.WriteLine(k); Console.ReadLine();
        }
    }
}
