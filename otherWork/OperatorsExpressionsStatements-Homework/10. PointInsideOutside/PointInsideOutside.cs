using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideOutside
{
    class PointInsideOutside
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write x:");
            double xCoordinate = double.Parse(Console.ReadLine());
            Console.WriteLine("Write y:");
            double yCoordinate = double.Parse(Console.ReadLine());

            double insidePoint = Math.Sqrt((xCoordinate-1) * (xCoordinate-1) + (yCoordinate-1) * (yCoordinate-1));
            bool point = ((yCoordinate > 1) & (insidePoint < 1.5)) || ((yCoordinate < -1) & (insidePoint < 1.5)) || ((xCoordinate < -1) & (insidePoint < 1.5)) || ((xCoordinate > 6 ) & (insidePoint < 1.5));
            {
            
                Console.WriteLine("Point is inside the circle K(1,1),3) and otside the rectrangle-> {0}", point);
            }
            Console.ReadLine();    
        }
    }
}
