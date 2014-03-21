using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int prime = int.Parse(Console.ReadLine());
            bool isprime = true;
           if (prime < 2) { isprime = false; }else{
               for (int i = 2; i < prime; i++)
               {
                   if (prime % i == 0) { isprime = false; break; }
               }
            }
            
            Console.WriteLine(isprime);
            Console.ReadLine();
        }
    }
}
