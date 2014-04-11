using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Female_GPS
{
    class Program
    {
        static void Main(string[] args)
        {



            long N = long.Parse(Console.ReadLine());
            if (N < 0) { N = -N; }

            long oddSum = 0;
           long evenSum = 0;

            while (N > 0) {

                long lastDigit=N%10;

                if ((lastDigit & 1) == 1) { oddSum += lastDigit; } else { evenSum+=lastDigit;}

                N=(N-N%10)/10;
              //  Console.Write(lastDigit);
            }



            if (oddSum > evenSum)
            { 
             Console.Write("left {0}",oddSum);

            }
            if (oddSum < evenSum)
            {
            Console.Write("right {0}",evenSum);

            }
            if (oddSum == evenSum)
            { 
          Console.Write("straight {0}",oddSum);
            }


       
          Console.ReadLine();



        }



    }
}
