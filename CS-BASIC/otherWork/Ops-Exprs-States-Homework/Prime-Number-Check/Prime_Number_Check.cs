using System;

class Prime_Number_Check
{
    static void Main()
    {
        byte br = 0;
        Console.Write("Enter an integer: ");
        sbyte n = sbyte.Parse(Console.ReadLine());
        bool isPrime;

        if (n < 2)
        {
            isPrime = false;
        }

        else
        {
            if (n == 2 || n == 3)
            {
                isPrime = true;
            }

            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        br++;
                        break;
                    }
                }

                if (br != 0)
                {
                    isPrime = false;
                }

                else
                {
                    isPrime = true;
                }
            }
        }

        Console.WriteLine(isPrime ? "The integer is prime." : "The integer is not prime.");
    }
}