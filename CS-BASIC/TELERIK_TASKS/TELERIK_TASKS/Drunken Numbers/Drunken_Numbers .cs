using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunken_Numbers
{
    class Drunken_Numbers 

    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int list = rotateRight( rotateRight((rotateRight(N))));

         // Console.WriteLine(((N - N % Math.Pow(10, K)) / Math.Pow(10, K)) % 10);
           
                Console.Write(list);
 
            Console.ReadLine();


        }



        public static int rotateRight(int N) { //list<int>

            int result = 0;
            List<int> numberDigits=new List<int>();
            int i=0;
            while (N / (Math.Pow(10, i)) > 1)
            { 
               
                numberDigits.Add((int)((N - N % Math.Pow(10, i)) / Math.Pow(10, i)) % 10);
                   i++;
            }

         numberDigits.Reverse();
           numberDigits.Insert(0, numberDigits[numberDigits.Count - 1]);
            numberDigits.RemoveAt(numberDigits.Count - 1);
           // if (numberDigits[0] == 0) { numberDigits.RemoveAt(0); }

            for (int k = 0;k < numberDigits.Count; k++)
            {
                result += numberDigits[k] *(int) Math.Pow(10, numberDigits.Count - k-1);
            }


            //return numberDigits;
            return result;
        }

        public static int rotateLeft(int N)
        {

            int result = 0;
            List<int> numberDigits = new List<int>();
            int i = 0;
            while (N / (Math.Pow(10, i)) > 1)
            {

                numberDigits.Add((int)((N - N % Math.Pow(10, i)) / Math.Pow(10, i)) % 10);
                i++;
            }

            numberDigits.Reverse();
            numberDigits.Add(numberDigits[0]);
            numberDigits.RemoveAt(0);

          //  if (numberDigits[0] == 0) { numberDigits.RemoveAt(0); }

            for (int k = 0; k < numberDigits.Count; k++)
            {
                result += numberDigits[k] * (int)Math.Pow(10, numberDigits.Count - k-1);
            }


            //return numberDigits;
            return result;
        }




    }
}
