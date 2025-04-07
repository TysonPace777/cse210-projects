using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        //Square
        Square s1 = new Square();
        s1.SetColor("Blue");
        s1.SetSide(5);

        //Rectangle
        Rectangle r1 = new Rectangle();
        r1.SetColor("Green");
        r1.SetSides(10, 2);

        //Circle
        Circle c1 = new Circle();
        c1.SetColor("Orange");
        c1.SetRadius(3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            string listColor = shape.GetColor();
            double listArea = shape.GetArea();
            Console.WriteLine($"{listColor} shape with an area of {listArea}");
        }
    }
}