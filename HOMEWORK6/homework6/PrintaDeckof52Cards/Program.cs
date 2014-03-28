using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintaDeckof52Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 14; i++) {
                string s = i + "";
                switch (i)
                {
                    case 11: s="J"; break;
                    case 12: s="Q"; break;
                    case 13: s="K"; break;
                    case 14: s="A"; break;
                }

                for (int k = 1;k <= 4; k++) {

                    switch(k){
                        case 1: Console.Write(s + "♣"+" "); break;
                        case 2: Console.Write(s + "♦" + " "); break;
                        case 3: Console.Write(s + "♥" + " "); break;
                        case 4: Console.Write(s + "♠" + " "); break;
                }
                    ; }
                Console.Write("\n");
               // Console.WriteLine();
                   
                 }
            Console.ReadLine();

        }
    }
}
