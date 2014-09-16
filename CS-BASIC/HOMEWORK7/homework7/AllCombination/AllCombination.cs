using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCombination
{
    class AllCombination
    {

        static void Main(string[] args)
        {

            int[] arr_ = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

           printListofList( getAll(arr_));



            Console.ReadLine();
        }


        public static List<List<int>> getAll(int[] seq) {

            List<List<int>> result = new List<List<int>>();
            int p = 0;

            for (int n = 0;n < seq.Length  ;n++)
            {

                 for (int i = n; i < seq.Length ; i++)
                 {
                         result.Add(new List<int>());
                       
                     for (int k = i; k < seq.Length; k++)
                     {

                         
                         result[p].Add(seq[k]);
                         
                     }
                          p++;
                 }

            }

            return result;
        }


        public static List<List<int>> getAllASC(List<List<int>> list)
        {

            List<List<int>> result = new List<List<int>>();
            int check = 0;

            for (int i = 0; i < list.Count; i++)
            {

                for (int k = 1; k < list[i].Count; k++)
                {

                    if (list[i][k] > list[i][k - 1]) { check++; }


                }

               if (check > 0) {  result.Add(list[i]); check = 0; }
             
            }


            return result;
        }


        public static void printListofList(List<List<int>> list)
        {

            foreach (List<int> s in list)
            {
                foreach (int k in s)
                {
                    Console.Write(k + " ");
                }
                Console.Write("\n");
            }

        }

    }
}
