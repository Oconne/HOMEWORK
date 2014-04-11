using System;

class OddEven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("It is odd. {0}", (n%2!=0 ? "true" : "false"));
    }
}

