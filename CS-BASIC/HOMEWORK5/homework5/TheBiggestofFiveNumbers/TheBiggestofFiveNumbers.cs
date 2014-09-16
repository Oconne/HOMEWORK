using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestofFiveNumbers
{
    class TheBiggestofFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());


            double max = a;
            if (b > max) { max = b; };
            if (c > max) { max = c; };
            if (d > max) { max = d; };
            if (e > max) { max = e; };

            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
