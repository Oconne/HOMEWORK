using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gravitation
{
    class Gravitation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write weight of a man on the earth.");
            double weight = int.Parse(Console.ReadLine());

            double moonWeight;
            moonWeight = ( 17* weight)/100;
            Console.WriteLine("Weight on the moon is {0}",moonWeight);
        }
    }
}
