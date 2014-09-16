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

//.......*.......
//......***......
//.....*.*.*.....
//....*..*..*....
//...*...*...*...
//..*....*....*..
//.*.....*.....*.
//***************
//.*.....*.....*.
//..*....*....*..
//...*...*...*...
//....*******....


            int N = int.Parse(Console.ReadLine());
            int   N1 = (N - 1) * 2 + N;
            List<string> simetry1 = new List<string>();

            for (int i = 0; i < N1; i++)
            {


                string a1 = new string('.', i+1 );
                string a2 = new string('*',  1);
                string a3;
                if (N - i >= 0) { a3 = new string('.', N - i); } else {  break; }
               
                //Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", a1, a2, a3, a2, a3, a2,a1);

                simetry1.Add(a1 + a2 + a3 + a2 + a3 + a2 + a1);


            }

            Console.WriteLine(new string('.',N+1)+"*"+new string('.',N+1));


             for (int i =simetry1.Count-1; i >=2 ; i--)
            {
                Console.WriteLine(simetry1[i]);

            }
            Console.WriteLine(new string('*',(N)*2+1));

            for (int i = 0; i < simetry1.Count()/2+1; i++)
            {
                Console.WriteLine(simetry1[i]);
            }

            if (N % 2 != 0)
            {
                Console.WriteLine(new string('.', N / 2 + 3) + new string('*', N) + new string('.', N / 2 + 3));
            }
            else { 
                 Console.WriteLine(new string('.', N / 2 + 2) + new string('*', N) + new string('.', N / 2 + 3));

            }

            Console.ReadLine();



        }
    }
}
