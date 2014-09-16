using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Letters
{
    class Count_of_Letters
    {


        static void Main(string[] args)
        {

            string Text = Console.ReadLine();

            List<string> list = new List<string>();


            foreach (char item in Text)
            {
                list.Add(item.ToString());
                
            }

           while(list.Count>0){

                string a = list[0];
                int k = 0;
                while (list.Contains(a)) { list.Remove(a); k++; }
                if (a != " ") { Console.WriteLine("{0} -> {1}", a, k); };
            }


            Console.ReadLine();
        }



    }
}
