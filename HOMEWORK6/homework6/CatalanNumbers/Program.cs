using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

//Problem 8.	Catalan Numbers



            int N;
           
            BigInteger Nfac = 1;
            BigInteger N_1fac = 1;
            BigInteger N2fac = 1;

            while (true)
            {
                N = int.Parse(Console.ReadLine());
                if (N > 1 && N < 100) { break; } else { Console.WriteLine("Invalid Input N"); }
            }
          

            for (int i = 1; i <= 2*N; i++)
            {

                if (i <= N) { Nfac *= i; }
                N2fac *= i; 
               if (i <= N +1 ) { N_1fac *= i; }
                ;
            }

            Console.WriteLine(N2fac /( N_1fac*Nfac));//

            Console.ReadLine();



        }
    }
}
