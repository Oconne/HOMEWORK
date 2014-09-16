using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int p = (n >> 3)&1;

            Console.WriteLine(p);//Convert.ToString(p, 2)
            
        }
    }
}
