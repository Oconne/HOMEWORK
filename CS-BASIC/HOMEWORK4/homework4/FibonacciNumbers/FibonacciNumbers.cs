using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a1 = 0;
            int a2 = 1;

            for (int i = 0; i < n; i++) { Console.WriteLine(a1); int c = a1; a1 = a1 + a2; a2 = c; }
            
            Console.ReadLine();

        }
    }
}
