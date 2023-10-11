using System;

class Program
{
    static void Main(string[] args)
    {
        // A list to hold the shapes.
        List<Shape> shapes = new List<Shape>();

        // Shapes instances for adding all the diffent shapes to the same list.
        Square ss = new Square("Green", 4);
        shapes.Add(ss);

        Rectangle rs = new Rectangle("Blue", 6, 3);
        shapes.Add(rs);

        Circle cs = new Circle("Silver", 7);
        shapes.Add(cs);

        // A loop for calling the GetColor() and GetArea() methods to get shape colors and compute areas.
        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
           
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}