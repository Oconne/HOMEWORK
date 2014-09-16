using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500) { Console.WriteLine("Invalid input!!!"); };

            float b= float.Parse(Console.ReadLine()) ;
            float c = float.Parse(Console.ReadLine());
            string b_ = "f2";
            string c_ = "f3";
            if (b % 1 == 0) {b_="f0" ;} 
            if ( c % 1 == 0){c_="f0"; }
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:"+b_+"}|{3,-10:"+c_+"}|", a, Convert.ToString(a, 2).PadLeft(10, '0'),b,c);
            Console.ReadLine();

        }


    }
}
