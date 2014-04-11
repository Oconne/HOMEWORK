using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] digitalMatrix = new string[16, 5];

            int N = int.Parse(Console.ReadLine());
           string number = Convert.ToString(N, 2).PadLeft(16, '0');
         //   Console.WriteLine(number[0]);
            string one_ = ".#.,##.,.#.,.#.,###";
            string zero_ = "###,#.#,#.#,#.#,###";
            string[] one = one_.Split(',');
            string[] zero = zero_.Split(',');
            string digitalScreen="";


           for (int k = 0; k < 5; k++)   {

               for (int i = 0; i < 16; i++)
                {
                    string s = ""; if (i > 0) { s = "."; }
                   
                   if (number[i] =='1') { digitalScreen +=s+ one[k]; } else if(number[i] == '0') {digitalScreen +=s+ zero[k]; }
                  //  if (((N >>  i)&1) == 1) { digitalScreen += s + one[k]; } else if (((N >> i)&1) == 0) { digitalScreen += s + zero[k]; }

                }

                digitalScreen+="\n";
            }


            Console.Write(digitalScreen);
            Console.ReadLine();

        }




    }
}
