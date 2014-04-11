using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingIJ
{
    class DrawingIJ
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------



            // int N = int.Parse(Console.ReadLine());

           

            int w = 8 ;
            int h = w;
            string dot = ".";
            string star = "*";
            string left = "\\";
            string right = "/";
            string up = "|";
            string minus = "-";
            string plus = "+";
            string clomb = "@";
            int a = 7;

           

            for (int i = 0,z=0; i < h; i++,z++)     //row
            {
                if (i == h) { break; }           //exit

                for (int k = 0,  v = 0; k < w; k++,v++)
                {
                    int d = 10;
                    int p = 0;

                    if (true)     //<-------------------------           
                    {

                        Console.Write(right);


                    }
                  




                    else
                    {

                        Console.Write(dot);
                    }


                }

                Console.WriteLine();

            }
          


            Console.ReadLine();
            //-----------------------------------------------------------------------------------------
        }
        //-----------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------
    }
}



//(i + w / 2 >= k && i + w / 2 >= w - k - 1) && i < h / 2 && k < w / 2  // house-half && ((!(((i + k) % 2 == 0)) && ((w / 2 & 1) == 0)) || (((i + k) % 2 == 0)) && ((w / 2 & 1) == 1))  raeta triang

//  i==h/2 || k==w/2  cross

// i==k || i==w-k-1  Xcross

// (i >= w - k - 1 || i <= k) && (i <= w - k - 1 || i>= k) sand glas

// k ==w-1 || i==w-k-w/2 || (i==0 && k>w/2 && k<=w) || (i==w/2)     trapecoid   
    
// i==k || i==w-k-1 || k==w/2 || i==h/2           UKflag(black&white)

//                                             teleric logo

// !(i + w / 2 < k || i+w / 2 < w - k - 1)&&(i<w/2+1)|| (i==w/2+1 && k==w/2)               fir tree
//                             
// i == k || i == w - k - 1+h/2                               forest road

// i == h - N - 1 || k == w / 2 || i == h - N - 1 - k || k == h - N - 1 + N+i-1    diamonds troll

//            || (i == 0 && k > h - N - 1 - 1 && k < h - N - 1 +N)

//            || i == k + h - N - 1 ||k == w - i - 1 + h - N - 1
//  i == k 
//  || i == w - k - 1

//   i ==a+k ||i ==a ||i ==a-k ||i==k-a ||i==k+a-w+1  ||i==-k+a+w-1       ||i==k+h-a-3 || i ==- k + h -a +1   || i == -k + h - a + h-2
// || i==k*3||i==k/4 k==a ||k==i+a||k==i-a||k==a-i|| k==a*3-i||i==a|| k == a * 3 + i||k==i-a * 3

//  i==h/2&&((k+1)%2==0) prekusnata hor liniq
//  k==h/2&&((i+1)%2==0) prekusnata ver liniq
//  k==h / 2 && ((i + 1) % 3 == 0)
//  i>=0 && (i+k)%2==0  raeta

//!(i + w / 2 < k || k < w / 2) && (i < w / 2) && ((i-k+1)%2)==0 carpet
//!(i + w / 2 < k || i + w / 2 < w - k - 1) && (i < w / 2) ^ !(i + w / 2 < k || k < w / 2) && (i < w / 2) && ((i+k)%2==0)
//! ((i > w / 2 - 1) && (k < i - w / 2 || i -w/2 > w - k - 1))&&(i>w/2-1)&&((i+k)%2==0)