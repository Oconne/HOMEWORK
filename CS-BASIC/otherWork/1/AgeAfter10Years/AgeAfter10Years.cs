using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your age:");
            int AgeNow = int.Parse(Console.ReadLine());
            int AgeAfter = AgeNow + 10;
            Console.WriteLine("Your age now:");
            Console.WriteLine(AgeNow);
            Console.WriteLine("Your age after 10 years will be:");
            Console.WriteLine(AgeAfter);
        }
    }

