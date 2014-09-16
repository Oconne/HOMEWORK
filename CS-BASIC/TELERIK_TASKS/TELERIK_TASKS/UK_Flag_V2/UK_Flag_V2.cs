using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UK_Flag_V2
{
    class UK_Flag_V2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftElement = 0;
            int rightElement = n - 1;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (leftElement == j)
                    {
                        Console.Write("\\");
                    }
                    else if (rightElement == j)
                    {
                        Console.Write("/");
                    }
                    else if (j == n / 2)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                leftElement++;
                rightElement--;
                Console.WriteLine();
            }

            leftElement++;
            rightElement--;

            for (int i = 0; i <= n - 1; i++)
            {
                if (i == n / 2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (leftElement == j)
                    {
                        Console.Write("\\");
                    }
                    else if (rightElement == j)
                    {
                        Console.Write("/");
                    }
                    else if (j == n / 2)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                leftElement++;
                rightElement--;
                Console.WriteLine();
            }
            Console.ReadLine();

            
        }
    }
}
