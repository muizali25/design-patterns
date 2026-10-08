Console.WriteLine("================================");
Console.WriteLine("      PROXY PATTERN - PROBLEM");
Console.WriteLine("================================\n");

Console.WriteLine("Loading images directly every time...\n");

var image1 = new RealImage("photo1.jpg");
image1.Display();

var image2 = new RealImage("photo2.jpg");
image2.Display();

Console.WriteLine("\nProblem: Expensive loading happens immediately, even if not needed.");

public interface IImage
{
    void Display();
}

public class RealImage : IImage
{
    public RealImage(string fileName)
    {
        FileName = fileName;
        LoadFromDisk();
    }

    public string FileName { get; }

    private void LoadFromDisk() =>
        Console.WriteLine($"Loading image from disk: {FileName}...");

    public void Display() => Console.WriteLine($"Displaying image: {FileName}");
}
