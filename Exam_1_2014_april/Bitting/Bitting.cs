using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitting
{
    class Bitting
    {
        static void Main(string[] args)
        {


            uint n=(uint)345;

                 Console.WriteLine(Convert.ToString(n, 2).PadLeft(16,'0'));

                 Console.WriteLine(Convert.ToString(getNum(n,makeMask(5,8)), 2).PadLeft(16,'0'));




                 Console.WriteLine(Convert.ToString(makeMask(4, 15), 2).PadLeft(16,'0'));
                 Console.WriteLine(Convert.ToString(makeMaskC(4,15), 2).PadLeft(16, '0'));

            Console.ReadLine();
        }

        public static uint getNum(uint num,uint mask) {


            return num & mask;
        
        }


        public static uint makeMask(int width, int position) {

            uint Mask;
            if (position >= width)
            {

                Mask = (~(uint)0 >> (32 - width)) << position-width+1;
            }
            else 
            {
                Mask = (~(uint)0 >> (32 - width)) >>(width- position-1);
            }


            return Mask;
        }

        public static uint makeMaskC(int width, int position)
        {
           uint Mask =0;

            for (int i = 0; i < position+1; i++)
            {
                if(i<width){


               Mask=(Mask<<1)|1;
                }
                else
                {

                    Mask = (Mask << 1);
                }
            }

           

            return Mask;
        }








//--------------------------------------------------------------------------------------------

    }
}
