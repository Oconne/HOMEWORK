using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
           

            for (int i = 0; i <= N; i++)
            {
                if (i == N / 2) { continue; }

                if (N - i * 2 > 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', N - i * 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.',N- i), new string('*',  i * 2-N));

                }



               
            }

           




            Console.Read();
        }
    }
}
