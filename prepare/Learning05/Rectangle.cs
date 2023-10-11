using System;

// Derived class Rectangle defined.
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor for setting length and width variable and accessing color from the base class.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

     // Virtual method for computing and returning a rectangular shape.
    public override double GetArea()
    {
        return _length * _width;
    }

}