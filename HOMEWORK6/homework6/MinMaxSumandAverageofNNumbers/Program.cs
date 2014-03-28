using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumandAverageofNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int? min=null;
            int? max=null;
            int sum=0;
            double avrg;

            for (int i = 1; i <= N; i++) {
               
               int p= int.Parse(Console.ReadLine());
               sum += p;
               if (max == null || p >= max) { max = p; } 
               if (min == null || p <= min) { min = p; } 

            }

            avrg = (double)sum / (double)N;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}",min,max,sum,avrg);

            Console.ReadLine();

        }
    }
}
