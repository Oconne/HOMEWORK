using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtractBitfromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = (n >> int.Parse(Console.ReadLine())) & 1;
            Console.WriteLine(p);//Convert.ToString(p, 2)
            

        }
    }
}
