using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Majority_Multiple
{
    class Least_Majority_Multiple
    {
        static void Main(string[] args)
        {

            int a;

            int b;

            int c;

            int d;

            int e;

            while (true) { a = int.Parse(Console.ReadLine()); if (a >= 1 && a <= 100) { break; } else { Console.WriteLine("Invali Input"); } }
            while (true) { b = int.Parse(Console.ReadLine()); if (b >= 1 && b <= 100) { break; } else { Console.WriteLine("Invali Input"); } }
            while (true) { c = int.Parse(Console.ReadLine()); if (c >= 1 && c <= 100) { break; } else { Console.WriteLine("Invali Input"); } }
            while (true) { d = int.Parse(Console.ReadLine()); if (d >= 1 && d <= 100) { break; } else { Console.WriteLine("Invali Input"); } }
            while (true) { e = int.Parse(Console.ReadLine()); if (e >= 1 && e <= 100) { break; } else { Console.WriteLine("Invali Input"); } }


            int count = 0;
            int lmm = 0; //Math.Max( Math.Max( Math.Max(a,b),Math.Max(c,d)),e);
            while (count < 3)
            {
                lmm++;
                count = 0;
                    if (lmm % a == 0) { count++; }
                    if (lmm % b == 0) { count++; }
                    if (lmm % c == 0) { count++; }
                    if (lmm % d == 0) { count++; }
                    if (lmm % e == 0) { count++; }

            }

            Console.WriteLine(lmm);

            Console.ReadLine();

        }
    }
}
