using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows1
{
    class Bulls_and_Cows1
    {
        static void Main(string[] args)
        {

          

            //int N = int.Parse(Console.ReadLine());
            //int[] BCI = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

            //if (BCI[0] == 3 && BCI[1] == 1) { Console.WriteLine("No");return; }

            //for (int i = 1111; i < 9999; i++)
            //{
            //    if (checkZero(i) == true) { continue; }
            //    if (checkBC(N, i)[0] == BCI[0]&&checkBC(N, i)[1] == BCI[1]) { Console.Write(i + " "); }
           

            //}
            int si = 2228;
            int ge = 1812;

            Console.Write(checkBC(si,ge)[0]+"   "+checkBC(si,ge)[1]);
            Console.ReadLine();

        }

        public static bool checkZero(int N_) {

         List<string> sicret = N_.ToString().Select(c => c.ToString()).ToList();
         foreach (var item in sicret)
         {
             if (item == "0") { return true; }
         }

            return false;
        }

        public static int[] checkBC(int NS,int NG) { 
        
        int[] BC ={0,0};

         List<string> sicret = NS.ToString().Select(c => c.ToString()).ToList();
         List<string> guess = NG.ToString().Select(c => c.ToString()).ToList();

         for (int i = 0; i < 4; i++)
         {
             if (sicret[i] == guess[i]) { BC[0]++; }
             else 
             {


                 for (int k = 0; k < 4 && k != i; k++)
                 {
                     if (sicret[k] == guess[i]) { BC[1]++; }
                 }
             }

         }

   
        return BC;
        }

    }
}
