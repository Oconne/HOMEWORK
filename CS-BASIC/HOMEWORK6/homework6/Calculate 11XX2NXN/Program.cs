using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_11XX2NXN
{
    class Program
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());
           int x = int.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 0; i <= N; i++) { 
                
                
                S+=(double)factorial(i)/(double)Math.Pow(x,i) ;

         
            }

            Console.WriteLine("{0:f5}",S);
            Console.ReadLine();

        }

        public static long factorial(int n) {
            long nfac=1;
            if (n == 0) { return 1; }
            for (int i = 1; i <=n; i++) {
                nfac *= i;
                ; }

            return nfac;
        }

    }
}
