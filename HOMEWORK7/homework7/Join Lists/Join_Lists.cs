using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Lists
{
    class Join_Lists
    {
        static void Main(string[] args)
        {

            List<string> listA = new List<string>();

            List<string> listB = new List<string>();
            List<string> listC = new List<string>();


            listA = Console.ReadLine().Split(' ').ToList<string>();
            listB = Console.ReadLine().Split(' ').ToList<string>();
        //    listC = Console.ReadLine().Split(' ').ToList<string>();
       //    listA.Concat(listB);
        //   

            foreach (string s in listB)
            {
                listA.Add(s);
            }

           listA.Sort();
           listC.Add(listA[0]);
            for (int i = 1; i < listA.Count; i++)
            {
                if (listA[i] != listA[i - 1]) { listC.Add(listA[i]); }
            }

            foreach (string s in listC)
            {
                Console.Write(  s+" ");
            }


            Console.ReadLine();
        }
    }
}
