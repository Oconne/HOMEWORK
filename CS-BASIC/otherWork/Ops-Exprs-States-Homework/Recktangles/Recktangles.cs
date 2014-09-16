using System;

class Recktangles
{
    static void Main()
    {
        Console.Write("Enter width of the recktangle: ");
        double Width = double.Parse(Console.ReadLine());
        Console.Write("Enter height of the recktangle: ");
        double Height = double.Parse(Console.ReadLine());
        double Area = Width * Height;
        double Perimeter = 2*(Width + Height);
        Console.WriteLine("The recktangle's area is: {0}", Area);
        Console.WriteLine("The recktangle's perimeter is: {0}", Perimeter);
    }
}