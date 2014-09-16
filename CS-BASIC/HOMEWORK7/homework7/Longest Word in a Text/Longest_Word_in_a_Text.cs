using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Word_in_a_Text
{
    class Longest_Word_in_a_Text
    {
        static void Main(string[] args)
        {

            List<string> listA = new List<string>();

            listA = Console.ReadLine().Split(' ').ToList<string>();

            int max=0;
            string str="";
            foreach (var s in listA)
            {
                if (s.Length >= max) { max = s.Length; str = s; }
            }

            Console.WriteLine(str);
            Console.ReadLine();


        }
    }
}
