﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit = 0;
            int count = 10;
            Console.WriteLine(Convert.ToString(n,2)) ;
            for (int i = 0; i <= 10; i++)
            {
                digit = n & (1 << i);
                if (digit == 0)
                {
                    Console.WriteLine("A{0}", count - i);
                }
            }

            Console.ReadLine();

        }
    }
}
