﻿namespace Polygons.Library;

class Square : ConcreteRegularPolygan
{
    public Square(int length) : base(4, length)
    {
    }

    public override double GetArea() => SideLength * SideLength;
}