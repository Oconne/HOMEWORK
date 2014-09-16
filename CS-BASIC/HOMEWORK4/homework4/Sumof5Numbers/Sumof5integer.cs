using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sumof5Numbers
{
    class sumof5integer
    {
        static void Main(string[] args)
        {
            double sum=0;
            for(int i=0;i<5;i++){sum+=double.Parse(Console.ReadLine());}
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
