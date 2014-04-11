using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Matrix_of_Palindromes
    {
        static void Main(string[] args)
        {

            writeMatrix(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

          //  Console.WriteLine((int)'b');
           // Console.WriteLine((char)50);
            

            Console.ReadLine();

        }


        public static string writPalinndrome(int i,int j)
        {
            string result="";
            int I = 97 + i;
            int J = 97 + j;

            result = ((char)I).ToString() + ((char)J).ToString() + ((char)I).ToString();

            return result;

        }

        public static void writeMatrix(int x,int y) {

            for (int i_ = 0; i_ < x; i_++) {

                for (int j_ = 0; j_ < y; j_++) { 

                Console.Write(writPalinndrome(i_,j_+i_) + " ");

                }
                Console.WriteLine();
            
            }


                
        
        }


    }
}
