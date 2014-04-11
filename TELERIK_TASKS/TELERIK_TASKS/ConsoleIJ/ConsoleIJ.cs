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
   //k ==w-1 || i==w-k-w/2 || (i==0 && k>w/2 && k<=w) || (i==w/2)            trapecoid       
   // i==k || i==w-k-1 || k==w/2 || i==h/2           UKflag



            int w = N;
            int h = w;
            string dot = ".";
            string star = "*";
            string left="\\";
            string right = "/";
            string up = "|";
            string minus = "-";
            string plus = "+";

            for (int i = 0; i < h; i++)     //row
            {
                   if (i ==  w) { break; }           //exit

                for (int k = 0; k < w; k++)   
                {


                    if (i == k )      //<-------------------------           
                    {
                        if (k == w / 2 && i == h / 2) { Console.Write(plus); }
                        else
                        {
                            Console.Write(left);
                        }

                    }
                    else if (i == w - k - 1)
                    {
                      Console.Write(right);

                    }
                    else if (k == w / 2)
                    {
                    Console.Write(up);
                    
                    }
                    else if (i == h / 2)
                    {

                       Console.Write(minus); 
                    
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
