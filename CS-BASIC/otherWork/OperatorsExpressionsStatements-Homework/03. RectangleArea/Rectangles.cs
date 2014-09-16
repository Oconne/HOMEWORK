
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RectangleArea
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write wight:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Write height:");
            double height = double.Parse(Console.ReadLine());

            double rectanglePerimeter = 2 * height + 2 * width;
            Console.WriteLine("The rectangle perimeter is: {0}", rectanglePerimeter);
            double rectangleArea = height * width;
            Console.WriteLine("The rectangle area is: {0}", rectangleArea);
        }
    }
}
