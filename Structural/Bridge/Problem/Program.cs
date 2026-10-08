Console.WriteLine("================================");
Console.WriteLine("     BRIDGE PATTERN - PROBLEM");
Console.WriteLine("================================\n");

// Problem: Combining shape types and renderers creates a class explosion.
IShape shape = new RedCircle();
shape.Draw();

shape = new BlueSquare();
shape.Draw();

Console.WriteLine("\nProblem: Every shape + renderer combination needs its own class.");
Console.WriteLine("Adding a new renderer or shape multiplies classes quickly.");

public interface IShape
{
    void Draw();
}

public class RedCircle : IShape
{
    public void Draw() => Console.WriteLine("Drawing red circle with vector renderer...");
}

public class BlueSquare : IShape
{
    public void Draw() => Console.WriteLine("Drawing blue square with raster renderer...");
}
