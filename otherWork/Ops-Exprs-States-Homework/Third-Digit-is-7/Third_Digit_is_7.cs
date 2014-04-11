using System;

class Third_Digit_is_7
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        bool Third_Digit_is_7 = (n/100 - 7)%10 == 0;
        Console.WriteLine(Third_Digit_is_7 ? "The third digit is 7." : "The third digit is not 7.");
    }
}