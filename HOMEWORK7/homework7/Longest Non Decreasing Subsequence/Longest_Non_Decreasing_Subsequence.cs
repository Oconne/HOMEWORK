using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Non_Decreasing_Subsequence
{
    class Longest_Non_Decreasing_Subsequence
    {
        static void Main(string[] args)
        {
            int[] arr0=new int[]{7, 3, 5, 8, -1, 6, 7};



            int[] arr_ = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            printListofList(FindLongestSequence(arr_));

            printList(FindLongestSequence(arr_)[getMaxList(FindLongestSequence(arr_))]);


            
            Console.ReadLine();
        }

        public static List<List<int>> FindLongestSequence(int[] seq)
    {
       
           List<int> mask=new List<int>();
           List<List<int>> result = new List<List<int>>();

           

           for (int k = 0; k < seq.Length; k++)
           {

           result.Add(new List<int>());
           result[k].Add(seq[k]);

              for (int i = k+1; i < seq.Length; i++)
                         {
                             if (seq[i] >= result[k].Last()) { result[k].Add(seq[i]); } else {
                             
                             
                             
                             }
                         }

           }

        return result ;
    }


        public static void printArray(int[] arr) {

            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine(); ;
        }




        public static void printListofList( List<List<int>> list) {

            foreach (List<int> s in list)
            {
                foreach (int k in s)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }
        
       
        
        }
        public static int getMaxList(List<List<int>> list) {
            int maxIndex = 0;
            int maxCount = 0;

           for (int i = 0; i < list.Count; i++)
			{


                if (list[i].Count > maxCount) { maxIndex = i; maxCount = list.Count; }
            }

            return maxIndex;
        }


        public static void printList(List<int> list){

            foreach (int k in list)
            {
                Console.Write(k+" ");
            }
        
        }


    }
}
