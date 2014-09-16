using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertAlgoritam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;

            int i = 0;
            bool condition = i < N;

          while(condition)
            {
                i++;
                Console.WriteLine("{0}{1}{0}",new string('.',i),new string('*',N-i));

                if (i - N == -1) { condition = i > N;  }

            }

            Console.Read();

        }
    }
}
