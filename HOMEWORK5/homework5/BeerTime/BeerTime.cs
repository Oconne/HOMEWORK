using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {

            //http://msdn.microsoft.com/en-us/library/system.datetime.compare.aspx

            //t1<t2-->-1,t1==t2--->0,t2>t1-->1

            DateTime dt = DateTime.Parse(Console.ReadLine()); 

            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");

            if (DateTime.Compare(startTime,dt)==-1) { Console.WriteLine("Beer Time"); }
            else if (DateTime.Compare(endTime, dt) == 1) { Console.WriteLine("Beer Time"); }
            else { Console.WriteLine("Non-Beer Time"); }
           
            Console.ReadLine();
        }
    }
}
