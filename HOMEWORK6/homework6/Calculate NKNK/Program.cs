using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate_NKNK
{
    class Program
    {
        static void Main(string[] args)
        {

    //Problem 7.	Calculate N! / (K! * (N-K)!)

            long N;
            long k;

          BigInteger    Nfac = 1;
          BigInteger    kfac = 1;
          BigInteger  N_kfac = 1;

            
            while (true)
            {
                N = long.Parse(Console.ReadLine());
                if (N > 2 && N < 100) { break; } else { Console.WriteLine("Invalid Input N"); }
            }
            while (true)
            {
                k = long.Parse(Console.ReadLine());
                if (k > 1 && k < N) { break; } else { Console.WriteLine("Invalid Input k"); }
            }

            for (long i = 1; i <= N; i++)
            {

                Nfac *= i;
                if (i <= k) { kfac *= i; }
                if (i <= N - k) { N_kfac *= i; }
               
            }

            BigInteger result = Nfac / kfac / N_kfac;
           Console.WriteLine("{0}, {1}, {2}",Nfac,kfac,N_kfac);
           Console.WriteLine(result);

            Console.ReadLine();




        }
    }
}
