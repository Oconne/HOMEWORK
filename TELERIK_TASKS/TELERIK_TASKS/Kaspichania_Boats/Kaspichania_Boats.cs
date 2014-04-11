using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichania_Boats
{
    class Kaspichania_Boats
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            List<string> simetry1 = new List<string>();

            for (int i = 0; i < N; i++)
            {

                string a1 = new string('.', N-i);
                string a2 = ""; 
                if (i != 0) { a2 = new string('*', 1); }
                string a3="";
                if (i >=1) { a3 = new string('.', i-1); }
                string a4 = "*";

                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", a1, a2, a3, a4, a3, a2,a1);
                simetry1.Add(a1 + a2 + a3  + a4 +a3+ a2 + a1);
            }


            Console.WriteLine(new string('*', N*2+1) );

            for (int i =simetry1.Count-1; i >= N/2+1; i--)
            {
                  Console.WriteLine(simetry1[i]);

            }

            Console.WriteLine(new string('.', N / 2 +1) + new string('*', N) + new string('.', N / 2+1 ));
            Console.ReadLine();


        }
    }
}
