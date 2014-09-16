using System;

class MoonGravity
{
    static void Main()
    {
        Console.Write("Enter the weight of a man: ");
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine("The weight of a man on the Moon is: {0}", (weight*17 / 100));
    }
}