Console.WriteLine("================================");
Console.WriteLine("   COMPOSITE PATTERN - SOLUTION");
Console.WriteLine("================================\n");

IFileSystemNode documents = new Folder("Documents");
((Folder)documents).Add(new FileItem("notes.txt", 10));
((Folder)documents).Add(new FileItem("photo.jpg", 500));

IFileSystemNode projects = new Folder("Projects");
((Folder)projects).Add(new FileItem("app.cs", 25));
((Folder)projects).Add(documents);

Console.WriteLine($"Total size of Projects folder: {projects.GetSize()} KB");

Console.WriteLine("\nFiles and folders are treated uniformly through a common interface.");

public interface IFileSystemNode
{
    string Name { get; }
    int GetSize();
}

public class FileItem : IFileSystemNode
{
    public FileItem(string name, int sizeKb)
    {
        Name = name;
        SizeKb = sizeKb;
    }

    public string Name { get; }
    public int SizeKb { get; }

    public int GetSize() => SizeKb;
}

public class Folder : IFileSystemNode
{
    private readonly List<IFileSystemNode> _children = new();

    public Folder(string name) => Name = name;

    public string Name { get; }

    public void Add(IFileSystemNode node) => _children.Add(node);

    public int GetSize() => _children.Sum(child => child.GetSize());
}
