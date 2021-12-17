using Polygons.Library;

namespace Polygons;

public class Program
{
    public static void Main(string[] args)
    {

        var square = new Square(5);
        DisplayPolygon("Square", square);

        Triangle triangle = new(5);
        DisplayPolygon("Triangle", triangle);

        Octagon octagon = new(5);
        DisplayPolygon("Octagen", octagon);

        RegularPolygonReader reqularPolygonReader = new(numberofPolygans: 4);
        UseConcreteType(reqularPolygonReader);
        UseAbstractType(reqularPolygonReader);

        Console.ReadLine();
    }

    private static void UseConcreteType(RegularPolygonReader reqularPolygonReader)
    {
        /*
         * If type of reqularPolygonReader.Polygons returns a list instead of Array
         * we have to change this definition to list of IRegularPolygon
         * due to a Compile Error
         */
        //IRegularPolygon[] polygans = reqularPolygonReader.Polygons;
        List<IRegularPolygon> polygans = reqularPolygonReader.Polygons;
        
        foreach (var item in polygans)
            DisplayPolygon("Octagen through Array:", item);
    }

    private static void UseAbstractType(RegularPolygonReader reqularPolygonReader)
    {
        /*
         * If type of reqularPolygonReader.Polygons returns a list instead of Array
         * we DO NOT have to change this definition.
         * No Compile Error and No RunTime Error
         * Because we use an Interface which is an abstract definition
         * and we just need its functionality
         */
        IEnumerable<IRegularPolygon> polygans = reqularPolygonReader.Polygons;
        
        foreach (var item in polygans)
            DisplayPolygon("Octagen through IEnumerable:", item);
    }

    public static void DisplayPolygon(string polyganType, dynamic polygan)
    {

        Console.WriteLine($"{polyganType} Number of Sides: {polygan.NumberOfSides}");
        Console.WriteLine($"{polyganType} Side Length: {polygan.SideLength}");
        Console.WriteLine($"{polyganType} Perimeter: {polygan.GetPerimeter()}");
        Console.WriteLine($"{polyganType} Area: {polygan.GetArea()}\n\r");
    }
}

