using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall_Down
{
    class FallDown
    {
        static void Main(string[] args)
        {

            List<byte> screen = new List<byte>();
            for (int i = 0; i <8; i++)
            {
                screen.Add(byte.Parse(Console.ReadLine()));
            }



         //   Console.WriteLine(colision(screen[0], screen[1]));

           

            //foreach (byte item in screen)
            //{
            //    Console.WriteLine(Convert.ToString(item,2).PadLeft(8,'0'));
            //}


            for (int i = 6; i >= 0; i--)
            {


                for (int k =i; k < 7; k++)
                {
                    fall(ref screen, k);
                }

                
            }



        //    Console.WriteLine("------------------------");
         foreach (byte item in screen)
         {
                         Console.WriteLine(item);           //Console.WriteLine(Convert.ToString(item, 2).PadLeft(8, '0'));
         }


            Console.ReadLine();






        }


        public static void fall(ref List<byte> list, int n) {

            byte a = list[n];
            byte b = list[n+1];

           list[n] = (byte)(a & b);
            list[n+1] = (byte)(a | b);
        
        
        }

        public static bool colision(byte a,byte b) {


            if ((a | b) == a + b) { return true; } else { return false; }
          
        }



    }
}
