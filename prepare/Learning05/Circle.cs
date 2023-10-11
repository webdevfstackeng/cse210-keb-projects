using System;

public class Circle : Shape
{
    private double _radius;

    // Constructor for setting the radius variable and accessing color from the base class.
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

     // Virtual method computing a circular shape.
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}