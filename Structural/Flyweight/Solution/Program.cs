Console.WriteLine("================================");
Console.WriteLine("   FLYWEIGHT PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var factory = new TreeTypeFactory();
var forest = new List<Tree>();

for (int i = 0; i < 5; i++)
{
    var type = factory.GetTreeType("Oak", "Green", "assets/oak.png");
    forest.Add(new Tree(i * 10, i * 5, type));
}

foreach (var tree in forest)
{
    tree.Draw();
}

Console.WriteLine($"\nShared tree types created: {factory.CreatedCount}");
Console.WriteLine("Intrinsic shared state is stored once and reused.");

public class TreeType
{
    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }
}

public class TreeTypeFactory
{
    private readonly Dictionary<string, TreeType> _types = new();

    public int CreatedCount => _types.Count;

    public TreeType GetTreeType(string name, string color, string texture)
    {
        string key = $"{name}-{color}-{texture}";

        if (!_types.TryGetValue(key, out TreeType? type))
        {
            type = new TreeType(name, color, texture);
            _types[key] = type;
            Console.WriteLine($"Creating shared TreeType for {name}.");
        }

        return type;
    }
}

public class Tree
{
    public Tree(int x, int y, TreeType type)
    {
        X = x;
        Y = y;
        Type = type;
    }

    public int X { get; }
    public int Y { get; }
    public TreeType Type { get; }

    public void Draw() =>
        Console.WriteLine($"Drawing {Type.Color} {Type.Name} at ({X},{Y}) using {Type.Texture}");
}
