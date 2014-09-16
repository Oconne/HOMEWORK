using System;

class Poin_in_K_outside_R
{
    static void Main()
    {
        Console.Write("Enter the coordinates on X: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter the coordinates on Y: ");
        float y = float.Parse(Console.ReadLine());

        if (y <= 1)
        {
            Console.WriteLine("The point is not in the circle and out of the recktangle.");
        }

        else if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5)
        {
            Console.WriteLine("The point is in the circle and out of the recktangle.");
        }
        else
        {
            Console.WriteLine("The point is not in the circle and out of the recktangle.");
        }
    }
}