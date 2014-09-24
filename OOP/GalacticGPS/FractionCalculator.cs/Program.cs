using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction p1 = new Fraction(3, 6);
            p1.Numerator = 3;
            p1.Denuminator = 12;
            p1.Normalize();
            Fraction p2 = new Fraction(1, 2);
            Fraction p3 = p1 + p2;
            Console.WriteLine(  Fraction.GCD(3, 6));
            Console.WriteLine(p1.ToString() +" + "+ p2.ToString()+" = "+p3.ToString());
        }
    }
}
