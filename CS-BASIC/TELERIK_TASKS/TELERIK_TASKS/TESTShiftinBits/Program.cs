using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTShiftinBits
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            N = N << 10;

            Console.WriteLine(Convert.ToString(N,2));

            Console.ReadLine();


        }
    }
}
