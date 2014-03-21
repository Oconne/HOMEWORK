using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divideby7and_5
{
    class Program
    {
        static void Main(string[] args)
        { 
                int num = int.Parse(Console.ReadLine());
                if (num == 0) { Console.WriteLine(false); }
                else
                {
                    Console.WriteLine(num % 7 == 0 && num % 5 == 0);
                }
               Console.ReadLine();
            
        }
    }
}
