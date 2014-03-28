using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateNK
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N;
            int k;
            int Nfac=1;
            int kfac=1;

            while (true)
            {
                N = int.Parse(Console.ReadLine());
                if (N > 2 && N < 100) { break; } else { Console.WriteLine("Invalid Input N"); }
            }
            while (true)
            {
                k = int.Parse(Console.ReadLine());
                if (k > 1 && k < N) { break; } else { Console.WriteLine("Invalid Input k"); }
            }

            for (int i = 1; i <= N; i++) {

                Nfac *= i;
                if (i <= k) { kfac *= i; }
                ;}

            Console.WriteLine(Nfac/kfac);

            Console.ReadLine();



        }

        //public static long factorial(int n)
        //{
        //    long nfac = 1;
        //    if (n == 0) { return 1; }
        //    for (int i = 1; i <= n; i++)
        //    {
        //        nfac *= i;
        //        ;
        //    }

        //    return nfac;
        //}


    }
}
