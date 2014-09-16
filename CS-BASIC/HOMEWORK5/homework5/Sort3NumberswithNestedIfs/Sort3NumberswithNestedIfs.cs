using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumberswithNestedIfs
{
    class Sort3NumberswithNestedIfs
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
 
           

      if (a < b) {                                                                 // a < b here
            if (a < c) {                                                            //   a < c     : a the smallest
                   if (b < c) {                                                    //     b < c  : a < b < c
                                Console.WriteLine("{0} {1} {2}", c, b, a);}
                         else {                                                     //    c <= b : a < c <= b
                                Console.WriteLine("{0} {1} {2}", b, c, a);
                              }
                              }

                 else {         Console.WriteLine("{0} {1} {2}", b, a, c);        //   a >= c    : c <= a < b
                        
         }
      }
  else{                                                                                     // b <= a here
        if (b < c) {                                                                        //   b < c     : b the smallest
                 if (a < c) {                                                               //     a < c   : b <= a < c
                           Console.WriteLine("{0} {1} {2}", c, a, b);}
                      else  {                                                                    //     a >= c  : b < c <= a
                           Console.WriteLine("{0} {1} {2}", a, c, b);
                            }}
                       else {                                                                        //   c <= b    : c <= b <= a
                           Console.WriteLine("{0} {1} {2}", a, b, c);
     }
  }




            Console.ReadLine();

        }
    }
}
