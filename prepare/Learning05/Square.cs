using System;

// Derived class Square defined.
public class Square : Shape
{
    private double _side;

    // Constructor for setting _side variable and accessing color from the base class.
    public Square(string color, double side) : base(color)  
    {
        _side = side;
    }

    // Virtual method computing a square shape.
    public override double GetArea()
    {
        return _side * _side;
    }


}