using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Trolls
{
    class Diamond_Trolls
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());


            Console.WriteLine("{0}{1}{0}", new string('.', N / 2+1), new string('*',N*2+1-(new string('.', N / 2+1)+new string('.', N / 2+1)).Length));

            int z = 0;
            if (N % 2 == 0) { z = N / 2 - 1; } else { z = N / 2; }

            for (int i =z, k=0; (i < N)&&(N/2-k>=1); i++,k++)
            {
               


                 string a0 = new string('.', N / 2 - k); 
                 string a1 = new string('*', 1);
                 string a2 =  new string('.',  i); 

                  Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", a0, a1, a2);
            }

                  Console.WriteLine(new string('*',N*2+1));

            for (int i = 0; i < N; i++)
            {

                string a0 = new string('.', i+1);
                string a1 = new string('*', 1);
                string a2 = "";
                try { a2 = new string('.', N - 2 - i); }
                catch { Console.WriteLine("{0}{2}{1}{2}{0}", a0, a1, a2); break; }

                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", a0, a1, a2);


            }

           

            Console.ReadLine();
                 
        }
    }
}
