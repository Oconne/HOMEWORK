using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevenland_Numbers
{
    class Sevenland_Numbers
    {
        static void Main(string[] args)
        {



            int N = int.Parse(Console.ReadLine());
            int next=N;

            if (N % 10 == 6 && N%100!=66)
            {
                next = next - 6 + 10;
            }
            else if (N % 100 == 66 && N%1000!=666)
            {
                next = next - 66 + 100;

            }
            else if (N % 1000 == 666 && N % 10000 != 6666)
            {
                next = next - 666 + 1000;

            }
            else { next=next+1; }
            

           Console.WriteLine(next);
            Console.ReadLine();






        }




    }
}
