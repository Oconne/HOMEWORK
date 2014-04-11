using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberIsPrime
{
    class NumberIsPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number:");
            int num = int.Parse(Console.ReadLine());
            double numSqrt = Math.Sqrt(num);
            bool isPrime = true;

            for (int i = 2; i < numSqrt; i++)
            {
                if (num % i == 0 && i != num)
                    isPrime = false;
            }
            Console.WriteLine("It is Prime:{0}", isPrime);
        }
    }
}
