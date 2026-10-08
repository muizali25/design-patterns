Console.WriteLine("================================");
Console.WriteLine("   COMPOSITE PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var file1 = new FileItem("notes.txt", 10);
var file2 = new FileItem("photo.jpg", 500);

Console.WriteLine($"File size: {file1.GetSize()} KB");
Console.WriteLine($"File size: {file2.GetSize()} KB");

Console.WriteLine("\nProblem: Files and folders are handled differently.");
Console.WriteLine("Calculating total folder size requires special client logic.");

public class FileItem
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

public class Folder
{
    public Folder(string name) => Name = name;

    public string Name { get; }
    public List<FileItem> Files { get; } = new();
}
