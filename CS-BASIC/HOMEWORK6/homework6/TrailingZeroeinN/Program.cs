using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace TrailingZeroeinN
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int zeroCounter = 0;
          BigInteger k = 10;

            BigInteger Nfac = 1;
            for (int i = 1; i <= N; i++) {
                Nfac *= i;

                ;}

         
            while(Nfac%k==0){

             //   Console.WriteLine(k);
                zeroCounter++;
                k *= 10;
               
            }
           

            Console.WriteLine(zeroCounter);
            Console.ReadLine();
        }
    }
}
