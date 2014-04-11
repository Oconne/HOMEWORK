using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIJ
{
    class ConsoleIJ
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


            int w = N*2+1;
            int h =6+(N-3)/2*3;
            string dot = ".";
            string star = "*";
            string left = "\\";
            string right = "/";
            string up = "|";
            string minus = "-";
            string plus = "+";

            for (int i = 0; i < h; i++)     //row
            {
                if (i == w/2+2) { break; }           //exit

                for (int k = 0; k < w; k++)
                {
                    int d = 10;
                    int p = 0;

                    if (!(i + w / 2 < k || i+w / 2 < w - k - 1)&&(i<w/2+1)|| (i==w/2+1 && k==w/2) )     //<-------------------------           
                    {
                        
                            Console.Write(star);
                       

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
