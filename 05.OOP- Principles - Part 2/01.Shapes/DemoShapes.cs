using System;
using Shapes;

class DemoShapes
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(2,5),
            new Triangle(4, 3),
            new Square(5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} Surface:{1}",shape.GetType().Name,shape.CalculateSurface());
        }
    }
}