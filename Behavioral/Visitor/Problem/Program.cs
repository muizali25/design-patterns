Console.WriteLine("================================");
Console.WriteLine("     VISITOR PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(4, 6)
};

foreach (var shape in shapes)
{
    if (shape is Circle circle)
    {
        Console.WriteLine($"Exporting circle area: {circle.GetArea()}");
    }
    else if (shape is Rectangle rectangle)
    {
        Console.WriteLine($"Exporting rectangle area: {rectangle.GetArea()}");
    }
}

Console.WriteLine("\nProblem: Adding a new operation requires changing every shape class.");
Console.WriteLine("Shape classes accumulate unrelated responsibilities.");

public interface IShape
{
    double GetArea();
}

public class Circle : IShape
{
    public Circle(double radius) => Radius = radius;
    public double Radius { get; }

    public double GetArea() => Math.PI * Radius * Radius;
}

public class Rectangle : IShape
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; }
    public double Height { get; }

    public double GetArea() => Width * Height;
}
