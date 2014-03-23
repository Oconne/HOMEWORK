using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclePerimeterandArea
{
    class CirclePerimeterandArea
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("{0:f2} {1:f2}",perimeter,area);
            Console.ReadLine();
        }
    }
}
