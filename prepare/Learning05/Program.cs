using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2.4);
        square.SetColor("Green");

        Rectangle rectangle = new Rectangle(3.4, 5.9);
        rectangle.SetColor("Pink");

        Circle circle = new Circle(5.4);
        circle.SetColor("Red");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} <-> Area: {shape.GetArea()}");
        }
    }
}