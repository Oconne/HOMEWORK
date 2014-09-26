using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
  public static  class TypesOfInterestCalculatin
    {


        public static decimal GetSimpleInterest(decimal moneySum, double interest, int years)
        {
            // A = sum * (1 + interest * years)
            decimal simpleInterest = moneySum * (decimal)(1 + (interest * years / 100));
            return simpleInterest;
        }

        public static decimal GetCompoundInterest(decimal moneySum, double interest, int years)
        {
            // A = sum * (1 + interest / n)year * n, n=12
            decimal compoundInterest = moneySum * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
            return compoundInterest;
        }



    }
}
