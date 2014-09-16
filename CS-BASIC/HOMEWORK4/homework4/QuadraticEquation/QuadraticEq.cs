using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class QuadraticEq
    {
        static void Main(string[] args)
        {
            double coefA = double.Parse(Console.ReadLine());
            double coefB = double.Parse(Console.ReadLine());
            double coefC = double.Parse(Console.ReadLine());
            double determinant = (coefB * coefB) - (4 * coefA * coefC);

            if (determinant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("x1={0} x2={1}", (-coefB - Math.Sqrt(determinant)) / (2 * coefA),
                    (-coefB + Math.Sqrt(determinant)) / (2 * coefA));
                
            }
            else
            {
                Console.WriteLine("x1=x2={0}", -coefB / (2 * coefA));
            }

            Console.ReadLine();
        }
    }
}
