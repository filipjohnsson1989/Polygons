namespace Polygons.Library;

public class RegularPolygonReader
{
    // UseConcreteType in program class get Compile Error
    // Compare it with UseAbstractType which works perfectly
    //public IRegularPolygon[] Polygons { get; }
    public List<IRegularPolygon> Polygons { get; }
    public RegularPolygonReader(int numberofPolygans)
    {
        List<IRegularPolygon> polygons = new();
        for (int i = 0; i < numberofPolygans; i++)
            polygons.Add(new Octagon(i));

        // The changing for returning a list instead of an array
        //this.Polygons = polygons.ToArray();
        this.Polygons = polygons;

    }

}
