using Polygons.Library;

namespace Polygons;

public class Program
{
    public static void Main(string[] args)
    {

        var square = new Square(5);
        DisplayPolygon("Square", square);

        Console.ReadLine();
    }

    public static void DisplayPolygon(string polyganType, dynamic polygan)
    {

        Console.WriteLine($"{polyganType} Number of Sides: {polygan.NumberOfSides}");
        Console.WriteLine($"{polyganType} Side Length: {polygan.SideLength}");
        Console.WriteLine($"{polyganType} Perimeter: {polygan.GetPerimeter()}");
        Console.WriteLine($"{polyganType} Area: {polygan.GetArea()}");


    }
}


