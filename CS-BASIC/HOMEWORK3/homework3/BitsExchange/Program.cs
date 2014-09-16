using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++) { n = swapBit(n, 3 + i, 21); }
            Console.WriteLine(n);
            Console.ReadLine();
        }


        static int swapBit(int num, int position, int delta) {

            int p1 = (num >> position) & 1;
            int p2 = (num >> (position + delta)) & 1;

            num = setBit(num, position, p2);
            num = setBit(num, position + delta, p1);

            return num;
        }


        static int setBit(int num, int position, int bit) {

            if (bit == 0)
            {
                num=(~(1 << position)) & num;
            }
            else {
                num=(1 << position) | num; 
            }



            return num;
        }



    }
}
