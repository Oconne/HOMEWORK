using System;

class Check_a_Bit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter the position of a bit: ");
        int p = int.Parse(Console.ReadLine());
        bool Checker = ((n >> p) & 1 ) == 1;
        Console.WriteLine("The given bit's value is 1. {0}", Checker);
    }
}