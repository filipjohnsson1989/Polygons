namespace Polygons.Library;

public class ConcreteRegularPolygon 
{
    public int NumberOfSides { get; set; }
    public int SideLength { get; set; }
    public ConcreteRegularPolygon(int side, int length)
    {
        NumberOfSides = side;
        SideLength = length;
    }

    public double GetPerimeter() => NumberOfSides * SideLength;

    public virtual double GetArea() => throw new NotImplementedException();

}
