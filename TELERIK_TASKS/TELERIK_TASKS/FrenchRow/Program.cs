using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchRow
{
    class Program
    {
        static void Main(string[] args)
        {

            

                  int N=int.Parse(Console.ReadLine());

                  int Z = 0; int sum = 0;

            while (Z < N) {
              
                sum=0;
                for (int i = 0; i <= Z; i++)
                {

                    sum += i;
                }

               Console.Write((sum) + " ");
                Z++;  
            
            }



            Console.ReadLine();


        }
    }
}
