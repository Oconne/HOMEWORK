using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNoDivisibleb_3and7
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {

                if (!(i % 7 == 0 || i %3==0)) { Console.Write(i+" "); } 
                ; }

            Console.ReadLine();
        }
    }
}
