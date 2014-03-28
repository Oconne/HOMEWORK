using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
                Console.WriteLine(Fib(int.Parse(Console.ReadLine())));

        //        if (Console.ReadLine() == "q") { break; };
        //    }
        }

        public static int Fib(int n) { 
        
       
        int a1 = 0;
        int a2 = 1;
       

        for (int i = 0; i <= n; i++) { int  c = a1; a1 = a1 + a2; a2 = c; }


        return a1; 
        }
    }
}
