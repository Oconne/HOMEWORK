using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter the side A of the trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the side B of the trapezoid: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height of the trapezoid: ");
        double h = double.Parse(Console.ReadLine());
        double Area = (a + b) * h / 2;
        Console.WriteLine("The area of the trapezoid is: {0}", Area);
    }
}