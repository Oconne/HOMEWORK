using System;

    class Point_in_a_Circle
    {
        static void Main()
        {
            Console.Write("Enter the coordinates on X: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter the coordinates on Y: ");
            float y = float.Parse(Console.ReadLine());
            bool Inside = Math.Sqrt(x * x + y * y) <= 2.0;
            Console.WriteLine("The point is in the circle. {0}", Inside);
        }
    }