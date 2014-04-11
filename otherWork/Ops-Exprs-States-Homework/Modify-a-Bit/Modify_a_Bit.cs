using System;

class Modify_a_Bit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of a bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a value that this bit should take: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;

        if (v == 0)
        {
            mask = ~mask;
            n = n & mask;
        }

        else
        {
            n = n | mask;
        }

        Console.WriteLine("The new number is: {0}", n);
    }
}