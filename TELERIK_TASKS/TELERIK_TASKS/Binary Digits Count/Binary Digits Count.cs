using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Digits_Count
{
    class Program
    {

        static void Main(string[] args)
        {
            byte B = byte.Parse(Console.ReadLine());
            List<uint> numbers = new List<uint>();
            List<int> bitCounts = new List<int>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                numbers.Add(uint.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                bitCounts.Add(0);
                while (numbers[i] > 0) {

                    if ((numbers[i] & 1 )== B) { bitCounts[i]++; }

                    numbers[i] >>= 1;
                
                }


            }


            foreach (var item in bitCounts)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

        }

    }
}
