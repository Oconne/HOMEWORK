using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fir_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

              int N = int.Parse(Console.ReadLine());
              string a1="";
              string a3="";

           
            for (int i = 0; i < N-1; i++)
            {

                 a1 = new string('.', N - i - 1-1);
                 a3 = new string('*', i*2+1);
            
                Console.WriteLine("{0}{1}{2}", a1, a3, a1);

            }

            Console.WriteLine("{0}{1}{2}", new string('.', (a1 + a3 + a1).Length / 2), "*", new string('.', (a1 + a3 + a1).Length / 2));
            Console.ReadLine();
        }



        
    }
}
