using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_All_Love_Bits
{
    class We_All_Love_Bits
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= N; i++)
            {
                
                int P = int.Parse(Console.ReadLine());
                Console.WriteLine(Convert.ToString(P, 2));
                
                int Pnew = 0;
                while (P > 0)
                {
                    Pnew <<= 1;
                    if ((P & 1) == 1)
                    {
                        Pnew |= 1;
                    }
                    P >>= 1;
                }

                Console.WriteLine(Convert.ToString(Pnew, 2));
                Console.WriteLine(Pnew);
            }


            Console.Read();

        }
        
        public static int MyProperty(int k) {

           

                
           return k     ; }
    }
}
