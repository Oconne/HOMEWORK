using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Names
{
    class Count_of_Names
    {
        static void Main(string[] args)
        {

          //  string Text = Console.ReadLine();

            List<string> list = Console.ReadLine().Split(' ').ToList<string>();
            List<string> listA =new List<string>();

            

           while(list.Count>0){

                string a = list[0];
                int k = 0;
                while (list.Contains(a)) { list.Remove(a); k++; }
                if (a != " ") { //Console.WriteLine("{0} -> {1}", a, k); 
                    listA.Add(string.Format("{0} -> {1}", a, k));
                };
            }

           listA.Sort();

           foreach (var item in listA)
           {
               Console.WriteLine(item);
           }

           Console.ReadLine();



        }
    }
}
