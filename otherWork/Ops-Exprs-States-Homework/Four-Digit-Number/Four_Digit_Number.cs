using System;

class Four_Digit_Number
{
    static void Main()
    {
        Console.Write("Enter a four-digit integer: ");
        int n = int.Parse(Console.ReadLine());
        int d = n % 10;
        int c = n / 10 % 10;
        int b = n / 100 % 10;
        int a = n / 1000;
        Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
        Console.WriteLine("The reversed number is: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("The last digit in front: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
    }
}