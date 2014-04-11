using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class subs
    {
        static void Main(string[] args)
        {
           // string[] source = new string[] { "dog", "cat", "mouse" };
            int[] source= Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            List<List<int>> result = new List<List<int>>();



            for (int i = 0; i < Math.Pow(2, source.Length); i++)
            {
                //int[] combination = new int[source.Length];
                List<int> comb = new List<int>();

                   for (int j = 0; j < source.Length; j++)
                         {
                            if ((i & (1 << (source.Length - j - 1))) != 0)
                                 {
                       // comb[j] = source[j];
                                comb.Add(source[j]);
                                  }
                                }

                      result.Add(comb);
                //Console.WriteLine("[{0}, {1}, {2}]", combination[0], combination[1], combination[2]);
            }

            result=getAllASC(result);

        //    Console.WriteLine(getMaxList(result));


            foreach (int s in result[getMaxList(result)])
            {
                Console.Write(s + " ");
            };



            //foreach (List<int> item in result)
            //{
            //    foreach (int i in item)
            //    {
            //        Console.Write(i + "");
            //    }
            //    Console.WriteLine();
            //}



            Console.ReadLine();
        }

        public static List<List<int>> getAllCombinations(int[] source)
        {

            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < Math.Pow(2, source.Length); i++)
            {

                List<int> combination = new List<int>();

                for (int j = 0; j < source.Length; j++)
                {
                    if ((i & (1 << (source.Length - j - 1))) != 0)
                    {

                        combination.Add(source[j]);
                    }
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

                    if (list[i][k] <=list[i][k - 1]) { check++; }


                }

                if (check == 0) { result.Add(list[i]); check = 0; }
                check = 0;
            }


            return result;
        }

        public static int getMaxList(List<List<int>> list)
        {
            int maxIndex = 0;
            int maxCount = 0;

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Count > maxCount) { maxIndex = i; maxCount = list[i].Count; }
            }

            return maxIndex;
        }




    }
}


//string[] source = new string[] { "dog", "cat", "mouse" };
// for (int i = 0; i < Math.Pow(2, source.Length); i++)
// {
//     string[] combination = new string[source.Length];
//     for (int j = 0; j < source.Length; j++)
//     {
//         if ((i & (1 << (source.Length - j - 1))) != 0)
//         {
//             combination[j] = source[j];
//         }
//    }
//    Console.WriteLine("[{0}, {1}, {2}]", combination[0], combination[1], combination[2]);
//}