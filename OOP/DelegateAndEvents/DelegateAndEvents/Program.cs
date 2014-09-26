using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{


    class Program
    {
     static void Main(string[] args)
        {

            InterestCalculator p = new InterestCalculator(500, 5.6, 10, TypesOfInterestCalculatin.GetCompoundInterest);
            Console.WriteLine(p.ToString());
            p.Years = 71;
            Console.WriteLine(p.ToString());


            p=new InterestCalculator(2500, 7.2, 15, TypesOfInterestCalculatin.GetSimpleInterest);
            Console.WriteLine(p.ToString());

            Console.WriteLine("\n\n===================================\n\n");

           InterestCalculator p2 = new InterestCalculator(500, 5.6, 10, TypesOfInterestCalculatin.GetCompoundInterest);
           Console.WriteLine(p2.ToString());
           p2.Sum = 2500;
           p2.Interest = 7.2;
           p2.Years = 15;
           p2.TypeOfInterest = TypesOfInterestCalculatin.GetSimpleInterest;
           Console.WriteLine(p2.ToString());


        }

    }


}
