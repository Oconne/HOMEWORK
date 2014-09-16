using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckaBitatGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = (n >> int.Parse(Console.ReadLine())) & 1;
            Console.WriteLine(p==1);

        }
    }
}
