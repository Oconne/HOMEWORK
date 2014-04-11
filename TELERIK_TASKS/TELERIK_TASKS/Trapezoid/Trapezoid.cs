using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}", new string('.', n), new string('*', n));


            for (int i = 1; i < n; i++)
            {
                 Console.WriteLine("{0}{1}{2}{3}", new string('.', n-i),"*", new string('.',n-2+ i),"*");
            }



            Console.WriteLine("{0}{1}", new string('*', n), new string('*', n));

            Console.ReadLine();
        }
    }
}
