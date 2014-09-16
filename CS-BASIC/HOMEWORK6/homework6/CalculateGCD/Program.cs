using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {

//            Problem 10.	* Calculate GCD
//Write a program that calculates the greatest common divisor
//            (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). Examples:

//VARIANT 1

           int a = Math.Abs( int.Parse(Console.ReadLine()));
            int b =  Math.Abs(int.Parse(Console.ReadLine()));
            int devisorMaxCount = Math.Min(a, b);
            int gcd =devisorMaxCount;

            while (true) {

                if (a % devisorMaxCount == 0 && b % devisorMaxCount == 0) { gcd = devisorMaxCount; break; }
                gcd--;
            
            }

            Console.WriteLine(gcd);

           Console.WriteLine("___________________");

 //VARIANT 2

//           Euclid :

//                                    gcd(a,b)=gcd(b,amodb)
//                                       gcd(a,0)=a


            Console.WriteLine(GCD(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));

            Console.ReadLine();



        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
            {                              
                return a;                                
            }
            else
            {
                return GCD(b, a % b);
            }
        }


    }
}
