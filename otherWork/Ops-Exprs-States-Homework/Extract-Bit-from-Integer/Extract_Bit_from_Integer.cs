using System;

class Extract_Bit_from_Integer
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter the position of a bit: ");
        int p = int.Parse(Console.ReadLine());
        uint nRightp = n >> p;
        Console.WriteLine("The value of this bit is: {0}", nRightp & 1);
    }
}