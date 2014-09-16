using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST2
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine((int)'?');
            Console.ReadLine();

        }



        public static uint createMask(int width,int position) {

            uint mask = (~(uint)0 >> (32 - width)) << ( position);
        
        return mask;
        
        }
    }
}
