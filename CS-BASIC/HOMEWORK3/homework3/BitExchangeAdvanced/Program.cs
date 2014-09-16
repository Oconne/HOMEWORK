using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitExchangeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bitExc(long.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }


        static long bitExc(long n,int p,int q, int k){

            for (int i = 0; i < k; i++) { n = swapBit(n, p+i , q-p); }
    
             return n;
          }

        static long swapBit(long num, int position, int delta) {

            long p1 = (num >> position) & 1;
            long p2 = (num >> (position + delta)) & 1;

            num = setBit(num, position, (int)p2);
            num = setBit(num, position + delta, (int)p1);

            return num;
        }


        static long setBit(long num, int position, int bit)
        {

            if (bit == 0)
            {
                num = (~((long)1 << position)) & num;
            }
            else
            {
                num = ((long)1 << position) | num;
            }
            return num;
        }
    }
}
