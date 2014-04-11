using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write side A:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Write side B:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Write height:");
            double height = double.Parse(Console.ReadLine());

            double trapezoidArea = ((sideA + sideB) * height) / 2;
            Console.WriteLine("The trapezoid area is: {0}", trapezoidArea);
        }
    }
}
