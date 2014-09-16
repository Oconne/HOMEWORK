using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestof3Numbers
{
    class TheBiggestof3Numbers
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = a;
            if (b >d) {d=b; };
            if (c > d) { d = c; };

            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
