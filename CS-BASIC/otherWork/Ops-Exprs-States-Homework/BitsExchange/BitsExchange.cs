using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        long k = n;
        long l = n;
        long mask;

        long Bit3 = (l >> 3) & 1;
        if (Bit3 == 0)
        {
            mask = ~(1 << 24);
            k = k & mask;
        }
        else
        {
            mask = 1 << 24;
            k = k | mask;
        }

        long Bit4 = (l >> 4) & 1;
        if (Bit4 == 0)
        {
            mask = ~(1 << 25);
            k = k & mask;
        }
        else
        {
            mask = 1 << 25;
            k = k | mask;
        }

        long Bit5 = (l >> 5) & 1;
        if (Bit5 == 0)
        {
            mask = ~(1 << 26);
            k = k & mask;
        }
        else
        {
            mask = 1 << 26;
            k = k | mask;
        }

        long Bit24 = (l >> 24) & 1;
        if (Bit24 == 0)
        {
            mask = ~(1 << 3);
            k = k & mask;
        }
        else
        {
            mask = 1 << 3;
            k = k | mask;
        }

        long Bit25 = (l >> 25) & 1;
        if (Bit25 == 0)
        {
            mask = ~(1 << 4);
            k = k & mask;
        }
        else
        {
            mask = 1 << 4;
            k = k | mask;
        }

        long Bit26 = (l >> 26) & 1;
        if (Bit26 == 0)
        {
            mask = ~(1 << 5);
            k = k & mask;
        }
        else
        {
            mask = 1 << 5;
            k = k | mask;
        }

        Console.WriteLine("The number after the exchange of the bits is: {0}", k);
    }
}