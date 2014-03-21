using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModifyaBitatGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());


            if (v ==0)
            {
                Console.WriteLine((~(1 << p)) & n);
            }
            else {Console.WriteLine((1 << p) | n); }
          
                Console.ReadLine(); 
        }
   
    }
}
