using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
          //  Console.WriteLine( ("000"+i).ToString().Substring(("000"+i).ToString().Length - 1 - 2, 1)=="7");
            Console.WriteLine((i- i % 100)/100%10==7);//
         //   Console.WriteLine(i/100-(i%100)/100);//modul

            Console.ReadLine();
        }
    }
}
