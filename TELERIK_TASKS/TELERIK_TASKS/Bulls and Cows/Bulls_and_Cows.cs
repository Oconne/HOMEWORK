using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    class Bulls_and_Cows
    {


        static void Main(string[] args)
        {

          //  int[] subject = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] subject = {  1, 2, 3, 4,5,6,7,8,9};
            printListOfLists(getAllCombinationsByProperties(subject));
            Console.ReadLine();

        }


        public static void printListOfLists(List<List<int>> list) {




            foreach (var item in list)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1 );
                }
                Console.WriteLine();
            }
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

                result.Add(combination);
            }

            return result;

        }

        public static List<List<int>> getAllCombinationsByProperties(int[] source)
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
                if (combination.Count == 4)
               {
                    result.Add(combination);
               }
            }

            return result;

        }



    }
}
