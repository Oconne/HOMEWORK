using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number:");
            long num = long.Parse(Console.ReadLine());
            long newNum = num / 100;
            Console.WriteLine("Third digit is seven: {0}", (newNum % 10 == 7));
        }
    }
}
