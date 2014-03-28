using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Area_in_Array
{
    class Longest_Area_in_Array
    {
        static void Main(string[] args)
        {


        //   printList(checkArea(readNumber(int.Parse(Console.ReadLine()))) );

           

            List<string> map = new List<string>();
            map = readNumber(int.Parse(Console.ReadLine()));
         //   map = distinkt(map);
         //   foreach (string s in map) { Console.WriteLine(s); }

            List<int> mapWidth = new List<int>();
            mapWidth = checkArea(map);
          //  printList(mapWidth);
            map = distinkt(map);
            Console.WriteLine(mapWidth.Max()); int i = 0;
            while (i++ < mapWidth.Max()) { Console.WriteLine(map[mapWidth.IndexOf(mapWidth.Max())]); }

            Console.ReadLine();

        }


        public static List<string> distinkt( List<string> l) { 
        
        List<string> l1=new List<string>();
          //  l.Sort();

            l1.Add(l[0]);
            for (int i = 1; i < l.Count(); i++) {

                if (l[i] != l[i - 1]) { l1.Add(l[i]); }
               
            
            }

                return l1;
        }

        public static List<string> readNumber(int n)
        {
            List<string> list = new List<string>();

            while (list.Count < n) { list.Add(Console.ReadLine().ToString()); }

        //    list.Sort();
            return list;

        }

        public static List<int> checkArea(List<string> list_) {

            List<int> listCount = new List<int>();
            List<string> listSign = new List<string>();

            int areaPosition=0;
            listCount.Add(1);
            listSign.Add(list_[0]);

                for (int i = 1; i < list_.Count; i++) {

                   if (list_[i] == list_[i - 1]) {  listCount[areaPosition]++; }
                   else{

                       listCount.Add(1); areaPosition++; listSign.Add(list_[i]);
                   }
               }



                return listCount;
        }

        public static void printList(List<int> list)
        {

            foreach (int s in list) { Console.Write(s + ", "); }
            Console.WriteLine("\n");

        }

        public static void printListA(List<int> list)
        {

            foreach (int s in list) { Console.WriteLine(s); }


        }


    }
}
