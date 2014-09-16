using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
 
            if (a > b)
            {
                a = a ^ b;
                b = a ^ b;
                a = a ^ b; 
            }
           
              Console.WriteLine(a + " " + b);
              Console.ReadLine();
                                       
        }
    }
}
