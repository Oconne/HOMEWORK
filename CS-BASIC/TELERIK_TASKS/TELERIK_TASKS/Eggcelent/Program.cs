using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());

            //i==k || i==w-k-1  cross
            //(i >= w - k - 1 || i <= k) && (i <= w - k - 1 || i>= k) sand glas
            //k ==w-1 || i==w-k-w/2 || (i==0 && k>w/2 && k<=w) || (i==w/2)     trapecoid       
            // i==k || i==w-k-1 || k==w/2 || i==h/2           UKflag(black&white)
            //              teleric logo
            //  !(i + w / 2 < k || i+w / 2 < w - k - 1)&&(i<w/2+1)|| (i==w/2+1 && k==w/2)               fir tree
            //                             diamonds troll


            int w = 3 * N + 1;
            int h = 2 * N;
            string dot = ".";
            string star = "*";
            string left = "\\";
            string right = "/";
            string up = "|";
            string minus = "-";
            string plus = "+";

            int pp=0;

            for (int i = 0; i < h; i++)     //row
            {
                if (i == h) { break; }           //exit

                for (int k = 0; k < w; k++)
                {
                    int d = 10;
                    int p = 0;
                    pp += 2;

                    if (i==0 && (k>N&&k<=2*N-1 )
                        || (i*2 == k-N*2+1)&&k<w-1
                        || (k==w-2 &&i>h/2-h/4 && i<h/2+h/4   )
                        || i == h-1 && (k > N && k <= 2 * N - 1)
                        || (k == 1 && i > h / 2 - h / 4 && i < h / 2 + h / 4)
                        || (i*2 == k+N*2+w/3-3)&&k<w-1
                        || i*2 == w - k  -2*N
                        || i * 2 == w - k +w/3-3+N*2-1

                        )     //<-------------------------           
                    {

                        Console.Write(star);


                    }
                    else   if(
                        
                     (i==h/2 && k>1 && k<w-1)
                    ||  (i==h/2-1 && k>1 && k<w-1)&&k==pp
                      
                      ){
                             
                      Console.Write("@");
                  }
                    else
                    {

                        Console.Write(dot);
                    }

                    
                }

                Console.WriteLine();

            }




            Console.ReadLine();









        }



    }
}
