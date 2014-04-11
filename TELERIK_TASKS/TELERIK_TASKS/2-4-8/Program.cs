using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int R=0;
            int div = 0;

            if (B == 2) {
                R = A % C; 
            }
            else if (B == 4) {
                R = A + C;
            }
            else if (B == 8)
            {
                R = A * C;
            }



            if (R % 4 == 0) { div = R / 4; }
            else
            {
            div=R%4;
            }


            Console.WriteLine(div);
             Console.WriteLine(R);
            Console.ReadLine();
        }
    }
}
