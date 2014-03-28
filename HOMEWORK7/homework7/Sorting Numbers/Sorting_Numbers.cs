using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Numbers
{
    class Sorting_Numbers
    {
        static void Main(string[] args)
        {

         printList(   readNumber(int.Parse(Console.ReadLine())));
         Console.ReadLine();

        }


        public static List<int> readNumber(int n)
        {
             List<int> list=new List<int>();

             while (list.Count < n) { list.Add(int.Parse(Console.ReadLine())); }

             list.Sort();
             return list;

        }


        public static void printList(List<int> list)
        {

            foreach (int s in list) { Console.WriteLine(s ); }
           

        }

    }
}
