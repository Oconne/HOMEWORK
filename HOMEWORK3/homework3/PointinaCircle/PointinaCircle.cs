using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointinaCircle
{
    class PointinaCircle
    {
        static void Main(string[] args)
        {
            var circle =new {  position=new {x=0,y=0},  radius=(double)2 };
            var point =new  { x =double.Parse( Console.ReadLine()), y = double.Parse( Console.ReadLine()) };

            Console.WriteLine(Math.Sqrt( Math.Pow(point.x,2)+Math.Pow(point.y,2))<=circle.radius);
            Console.ReadLine();
        }
    }
}
