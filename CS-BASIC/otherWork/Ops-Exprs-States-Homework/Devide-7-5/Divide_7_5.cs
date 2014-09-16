using System;

class Divide_7_5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool Divisible_by_35 = n%35==0;
        Console.WriteLine(Divisible_by_35);
    }
}