using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<string> p = new GenericList<string>();
            p.Add("bbbbb");
            p.Add("aa");
            p.Add("hhhhhhhhhh");
            p.Add("fff");

           // Console.WriteLine(p[2].ToString());

            for(int i=0;i<p.Count;i++)
            {
                Console.WriteLine(p[i]);
            }

            Console.WriteLine("====================");
            Console.WriteLine(p.Max());
            Console.WriteLine("====================");
            p.Insert(2, "ccccccccccccccccccc");
              for(int i=0;i<p.Count;i++)
             {
                 Console.WriteLine(p[i]);
             }
        }
    }
}
