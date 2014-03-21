using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourDigit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++) { sum += getDigit(num, i); }
            Console.WriteLine(sum);
            for (int i = 0; i < 4; i++) { Console.Write(getDigit(num, i)); } Console.WriteLine();
            Console.WriteLine(getDigit(num,3)*1000+getDigit(num,0)*100+getDigit(num,1)*10+getDigit(num,2));
            Console.WriteLine(getDigit(num, 3)  + getDigit(num, 0) * 1000 + getDigit(num, 1) * 10 + getDigit(num, 2)*100);
            Console.ReadLine();


        }

        static int getDigit(int i, int n) {
            int result;
            result = (i - i % (int)Math.Pow(10, n)) / (int)Math.Pow(10, n) % 10;

            return result;
        }
    }
}
