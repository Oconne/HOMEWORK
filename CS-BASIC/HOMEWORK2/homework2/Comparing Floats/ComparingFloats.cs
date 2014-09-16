using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
           
            float var1 = float.Parse(Console.ReadLine());
            float var2 = float.Parse(Console.ReadLine());
            double eps = 0.000001;
            
            Console.WriteLine(Math.Abs( (decimal)var1 - (decimal)var2) <(decimal)eps);
         
            Console.ReadLine();
      

        }
    }
}
