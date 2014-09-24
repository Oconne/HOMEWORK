using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator.cs
{
    struct Fraction
    {

        private long numerator;
        private long denuminator;



        public Fraction(long num, long denum):this() 
        {
            
            long gcd = Fraction.GCD(num, denum);
            this.Numerator = num / gcd;
            this.Denuminator = denum / gcd;


        
        }


        public long Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value;  }
        }

        public long Denuminator
        {
            get {return this.denuminator; }
            set {
                    if (value == 0)
                    {
                        throw new ArgumentException("Denuminator cant be zero");
                    }
                    this.denuminator = value;
                   
                }
        }
        
        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denuminator + first.Denuminator * second.Numerator,
                first.Denuminator * second.Denuminator);

        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denuminator - first.Denuminator * second.Numerator,
                first.Denuminator * second.Denuminator);
        }

        public static long GCD(long a, long b)
        {
            if (b == 0) { return a; } 
            return GCD(b, a % b);
          
        }

        public void Normalize() 
        {
            long num = this.Numerator;
            long denum = this.Denuminator;
            long gcd = Fraction.GCD(num, denum);
            this.Numerator = num / gcd;
            this.Denuminator = denum / gcd;

            
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}",this.Numerator,this.Denuminator);
        }

        public  decimal convertToDecimal()
        {
            return ((decimal)this.numerator / this.denuminator);
        }
    }
}
