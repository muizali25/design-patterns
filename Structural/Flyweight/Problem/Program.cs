Console.WriteLine("================================");
Console.WriteLine("   FLYWEIGHT PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var forest = new List<Tree>();

for (int i = 0; i < 5; i++)
{
    forest.Add(new Tree(i * 10, i * 5, "Oak", "Green", "assets/oak.png"));
}

Console.WriteLine($"Created {forest.Count} trees.");
Console.WriteLine("\nProblem: Each tree stores repeated shared data (name, color, texture).");
Console.WriteLine("Memory usage grows unnecessarily with many similar objects.");

public class Tree
{
    public Tree(int x, int y, string name, string color, string texture)
    {
        X = x;
        Y = y;
        Name = name;
        Color = color;
        Texture = texture;
    }

    public int X { get; }
    public int Y { get; }
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public void Draw() => Console.WriteLine($"Drawing {Color} {Name} at ({X},{Y}) using {Texture}");
}
