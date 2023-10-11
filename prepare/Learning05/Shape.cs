using System;
using System.Drawing;

public abstract class Shape  // Abstract base class
{
    private string _color;

    public Shape(string color)  //constructor that set color variable
    {
        _color = color;
    }

    public string GetColor()   // Color getter
    {
        return _color;
    }

    public void SetColor(string color)  // Color setter
    {
        _color = color;
    }

    public abstract double GetArea();  // Virtual method for computing areas of different shapes
     
}

