using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoiko_Tower
{
    class BatGoiko_Tower
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
           // int counter = -2;


         //   foreach(int s in rec(N)){Console.WriteLine(s);}

            List<int> seq = rec(N*2);

         //foreach(int s in seq){Console.WriteLine(s);}

            int k = 1;
            for (int i = 0; i < N; i++)
            {


                string a1 = new string('.', N - i - 1);
                string a2 = new string('/', 1);
                string a3;

                if (seq[k] == i)
                {
                    a3 = new string('-', (N - 1) * 2 + 2 - ((N - i - 1) * 2 + 2));
                    k++;
                }
                else
                {
                    a3 = new string('.', (N - 1) * 2 + 2 - ((N - i - 1) * 2 + 2));

                }

                string a4 = new string('\\', 1);
                Console.WriteLine("{0}{1}{2}{3}{4}", a1, a2, a3, a4, a1);

            }

            Console.ReadLine();
        }


        public static List<int> rec(int n){
            
            List<int> res=new List<int>();

           int counter=-2;

           for (int row = 0; row < n; row++)
        {
            for (int i = 0; i <= counter; i++)
            {

                row++;
                if (row == n)
                {
                    return res ;
                }
  
        }
                res.Add(row);
                counter++;
            }


           return res;
        } 
    }
}
