using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anacci2
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstLetter = char.Parse(Console.ReadLine()) - 64;
            int secondLetter = char.Parse(Console.ReadLine()) - 64;
            int L = int.Parse(Console.ReadLine());

            if (L == 1)
            {
                Console.WriteLine(getLetterByCode( firstLetter));
            }
            else
            {
                int a = secondLetter;
                Console.WriteLine(getLetterByCode( firstLetter));
                Console.WriteLine("{0}{1}",getLetterByCode( secondLetter), getLetterByCode( FibSum(firstLetter, secondLetter)));

               int N1 = firstLetter;
               int N2 = secondLetter;

                firstLetter = N2;
                secondLetter = FibSum(N1, N2);

            }

            for (int i = 0; i < L - 2; i++)
            {

               int N1 = firstLetter;
               int N2 = secondLetter;

                firstLetter = FibSum(N1, N2);
                secondLetter = FibSum(FibSum(N1, N2), N2);

                Console.WriteLine("{0}{1}{2}", getLetterByCode( firstLetter), new string(' ', i + 1),getLetterByCode( secondLetter));


            }


          //  Console.WriteLine(FibSum(2,3));
            Console.ReadLine();


        }

        public static char getLetterByCode(int letterCode) {

            return (char)(64 + letterCode);
        
        }

        public static int FibSum(int N1, int N2) {

            int result = N1+N2;
            if (result > 26) { return (N1 + N2) % 26; } else { return result; }
        
        
        }

    }
}
