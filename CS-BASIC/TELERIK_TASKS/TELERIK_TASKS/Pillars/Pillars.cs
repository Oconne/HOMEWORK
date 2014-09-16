using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Pillars
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            List<int> listSum = new List<int>();
            int   leftSum = 0;
            int   rightSum=0;


            for (int i = 0; i <8; i++)
            {
                list.Add(   Convert.ToString(int.Parse(Console.ReadLine()) , 2).PadLeft(8, '0'));
            }


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < 8; i++)
            {
                listSum.Add(columnSum(i, list));

                //Console.Write(columnSum(i, list) + " ");
            }
            //Console.WriteLine();

            bool bul = false;
            for (int i = 0; i < 8; i++)
            {


                for (int l = 0; l < i; l++)
                {
                    leftSum += listSum[l];
                }


                for (int r = i + 1; r < 8; r++)
                {
                    rightSum += listSum[r];
                }

                if (leftSum == rightSum) {

                    if (i == 0) { Console.WriteLine(0); Console.WriteLine(leftSum); bul = true; }
                   
                    else
                    {

                        Console.WriteLine(7 - i); Console.WriteLine(leftSum); bul = true;
                    }
                    
                    
                    
                    break; } 

           ///     Console.WriteLine(leftSum + "--" + rightSum);
            //    Console.WriteLine(listSum[i]);
                leftSum = 0; rightSum = 0;
            }

            if (bul == false) { Console.WriteLine("No"); }
            Console.ReadLine();

        }


        public static int columnSum(int column, List<string> list_) {

            int sum = 0;

            foreach (string s in list_)
            {
                sum +=  int.Parse(s[column].ToString());
            }


            return sum;
        }


    }
}
