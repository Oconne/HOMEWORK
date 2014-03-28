using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(int.Parse(Console.ReadLine()) ));
            Console.ReadLine();
        }

        public static bool IsPrime(  int prime) {

          
            bool isprime = true;
            if (prime < 2) { isprime = false; } 
            else { for (int i = 2; i < prime; i++) 
            { if (prime % i == 0) { isprime = false; break; } } }

            return isprime;

        }


    }
}
