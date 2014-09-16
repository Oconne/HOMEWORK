using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four-digit number");
            int number = int.Parse(Console.ReadLine());
            int a = (number / 1000)%10;
            int b = (number / 100)% 10;
            int c = (number / 10)% 10;
            int d = (number /1)% 10;

            int sum = a + b + c + d;
            int reverse = d * 1000 + c * 100 + b * 10 + a;
            int exchangefl = d * 1000 + b * 100 + c * 10 + a;
            int exchangemiddle = a * 1000 + c * 100 + b * 10 + d;

            Console.WriteLine("Sum : {0}",sum);
            Console.WriteLine("Reverse: {0}", reverse);
            Console.WriteLine("Last digit in the first position: {0}",exchangefl);
            Console.WriteLine("Exchange the second and the third digits: {0}",exchangemiddle);
        }
    }
}
