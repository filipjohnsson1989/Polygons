namespace Polygons.Library;

public class ConcreteRegularPolygan
{
    public int NumberOfSides { get; set; }
    public int SideLength { get; set; }

    public ConcreteRegularPolygan(int side, int length)
    {
        NumberOfSides = side;
        SideLength = length;
    }

    public double GetPerimeter() => NumberOfSides * SideLength;

    public virtual double GetArea() => throw new NotImplementedException();

}
