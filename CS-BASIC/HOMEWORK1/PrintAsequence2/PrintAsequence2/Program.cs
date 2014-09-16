using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAsequence2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sign = -1;
            for (int i = 2; i <= 1001; i++) { sign *= -1; Console.WriteLine((i * sign).ToString()); }
            Console.ReadLine();
        }
    }
}
