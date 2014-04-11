using System;

class ExchangeGivenBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter the position of the first bit of the first sequence: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the first bit of the second sequence: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the two sequences: ");
        int k = int.Parse(Console.ReadLine());
        int p1 = p + k - 1;
        int q1 = q + k - 1;
        long m = n;
        long l = n;
        long mask;
        long CurrentBit;

        if (p + k - 1 >= 32 || q + k - 1 >= 32 || p < 0 || q < 0 || k <= 0 || k >=32 || n >= UInt32.MaxValue)
        {
            Console.WriteLine("Out of range!!!");
        }

        else
        {
            if ((p >= q && p <= q1) || (p1 >= q && p1 <= q1))
            {
                Console.WriteLine("Overlapping!!");
            }

            else
            {
                for (int i = p; i <= p1; i++)
                {
                    CurrentBit = (l >> i) & 1;
                    if (CurrentBit == 0)
                    {
                        mask = ~(1 << q+i-p);
                        m = m & mask;
                    }
                    else
                    {
                        mask = 1 << q+i-p;
                        m = m | mask;
                    }
                }

                for (int i = q; i <= q1; i++)
                {
                    CurrentBit = (l >> i) & 1;
                    if (CurrentBit == 0)
                    {
                        mask = ~(1 << p + i - q);
                        m = m & mask;
                    }
                    else
                    {
                        mask = 1 << p + i - q;
                        m = m | mask;
                    }
                }

                Console.WriteLine("The integer after the set exchange is: {0}", m);
            }
        }
    }
}