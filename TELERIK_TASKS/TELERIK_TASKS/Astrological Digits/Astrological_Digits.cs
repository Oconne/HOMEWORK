using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrological_Digits
{
    class Astrological_Digits
    {
        static void Main(string[] args)
        {



            double N = double.Parse(Console.ReadLine());


            double sum = 0;
            double B = N; if (B < 0) { B = (double)-B; }
            string convertTo = B.ToString();
            if (B % 1 < 1 && B%1 !=0)
            {
                convertTo = convertTo.Remove(convertTo.IndexOf('.'), 1);
               B = Convert.ToDouble(convertTo);
            }
           
           
         //   Console.WriteLine(547600%10);

        l:
            while (B > 0)
            {
                sum += B % 10;
                B = (B - B % 10) / 10;

            }

            if (sum > 9) { B = sum; sum = 0; ;goto l; }



            Console.WriteLine("{0}", sum);

            
            Console.ReadLine();
         }




    }
}
