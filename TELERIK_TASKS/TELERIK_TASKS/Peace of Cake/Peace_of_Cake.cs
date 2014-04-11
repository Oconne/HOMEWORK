using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peace_of_Cake
{
    class Peace_of_Cake
    {
        static void Main(string[] args)
        {


            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());

            decimal amaunt = (decimal)A / B + (decimal)C / D;


            if (amaunt >= 1)
            {
                Console.WriteLine(Math.Floor(amaunt));

            } else {

                Console.WriteLine("{0:f22}", amaunt);
            }

            decimal nominator = A * D + C * B;
            decimal denominator = B * D;

            
                Console.WriteLine("{0}/{1}", nominator, denominator); 
           
           

            Console.ReadLine();

        }
    }
}
