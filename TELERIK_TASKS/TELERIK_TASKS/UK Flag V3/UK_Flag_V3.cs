using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UK_Flag_V3
{
    class UK_Flag_V3
    {


        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            List<string> simetry = new List<string>();


            for (int i = 0; i < N; i++)
            {
                try
                {
                    string a1 = new string('.', i);
                    string a2 = new string('\\', 1);
                    string a3 = new string('.', N / 2 - i);
                    string a4 = new string('|', 1);
                    string a5 = new string('/', 1);

                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", a1, a2, a3, a4, a3, a5, a1);
                    simetry.Add(a1 + a5 + a3 + a4 + a3 + a2 + a1);
                }
                catch { }

            }
            Console.WriteLine(new string('-', N /2+1)+"*"+new string('-', N /2+1));

            for (int i = simetry.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(simetry[i]);
            }



            Console.Read();

        }
    }
}
