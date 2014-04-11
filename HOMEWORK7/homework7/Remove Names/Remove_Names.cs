using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Names
{
    class Remove_Names
    {
        static void Main(string[] args)
        {

            List<string> listA = new List<string>();

            List<string> listB = new List<string>();

            listA = Console.ReadLine().Split(' ').ToList<string>();
            listB = Console.ReadLine().Split(' ').ToList<string>();

            foreach (string s in listB)
            {
                while (listA.Contains(s)) { listA.Remove(s); }
            }


        foreach (string s in listA)
     	{
            Console.Write(s + " ");
	    }

        Console.ReadLine();
 }


    }
}
