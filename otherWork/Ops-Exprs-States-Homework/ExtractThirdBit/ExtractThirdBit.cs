using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        uint nRight3 = n >> 3;
        Console.WriteLine("The value of the third bit is: {0}", nRight3 & 1);
    }
}