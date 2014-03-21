using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.ASCII;

            for (int i = 0; i < 128; i++)
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }

            Console.ReadLine();
        }
    }
}
