using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write x:");
            double xCoordinate = double.Parse(Console.ReadLine());
            Console.WriteLine("Write y:");
            double yCoordinate = double.Parse(Console.ReadLine());
            double insidePoint = Math.Sqrt(xCoordinate * xCoordinate + yCoordinate * yCoordinate);
            Console.WriteLine("Point is inside the circle K((0,0),2) -> {0}", (insidePoint < 2));
        }
    }
}
