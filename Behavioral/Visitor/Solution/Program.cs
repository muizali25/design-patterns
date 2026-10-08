Console.WriteLine("================================");
Console.WriteLine("     VISITOR PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(4, 6)
};

IShapeVisitor exporter = new AreaExportVisitor();

foreach (var shape in shapes)
{
    shape.Accept(exporter);
}

Console.WriteLine("\nNew operations can be added via visitors without changing shape classes.");

public interface IShapeVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}

public interface IShape
{
    double GetArea();
    void Accept(IShapeVisitor visitor);
}

public class Circle : IShape
{
    public Circle(double radius) => Radius = radius;
    public double Radius { get; }

    public double GetArea() => Math.PI * Radius * Radius;

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
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

    public void Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public class AreaExportVisitor : IShapeVisitor
{
    public void Visit(Circle circle) =>
        Console.WriteLine($"Exporting circle area: {circle.GetArea():F2}");

    public void Visit(Rectangle rectangle) =>
        Console.WriteLine($"Exporting rectangle area: {rectangle.GetArea():F2}");
}
