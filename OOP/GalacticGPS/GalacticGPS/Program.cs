using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {

            Location location = new Location(2.333333, 67.236790, Planet.Earth);

            Console.WriteLine(location);
        }
    }
}
