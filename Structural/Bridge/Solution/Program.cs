Console.WriteLine("================================");
Console.WriteLine("     BRIDGE PATTERN - SOLUTION");
Console.WriteLine("================================\n");

Shape circle = new Circle(new VectorRenderer(), "Red");
circle.Draw();

Shape square = new Square(new RasterRenderer(), "Blue");
square.Draw();

Console.WriteLine("\nShape and renderer vary independently.");
Console.WriteLine("No need for RedCircleVector, BlueSquareRaster, etc.");

public interface IRenderer
{
    void Render(string shape, string color);
}

public class VectorRenderer : IRenderer
{
    public void Render(string shape, string color) =>
        Console.WriteLine($"Drawing {color} {shape} with vector renderer...");
}

public class RasterRenderer : IRenderer
{
    public void Render(string shape, string color) =>
        Console.WriteLine($"Drawing {color} {shape} with raster renderer...");
}

public abstract class Shape
{
    protected Shape(IRenderer renderer, string color)
    {
        Renderer = renderer;
        Color = color;
    }

    protected IRenderer Renderer { get; }
    protected string Color { get; }

    public abstract void Draw();
}

public class Circle : Shape
{
    public Circle(IRenderer renderer, string color) : base(renderer, color) { }

    public override void Draw() => Renderer.Render("circle", Color);
}

public class Square : Shape
{
    public Square(IRenderer renderer, string color) : base(renderer, color) { }

    public override void Draw() => Renderer.Render("square", Color);
}
