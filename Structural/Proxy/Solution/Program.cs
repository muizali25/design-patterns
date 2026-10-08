Console.WriteLine("================================");
Console.WriteLine("      PROXY PATTERN - SOLUTION");
Console.WriteLine("================================\n");

Console.WriteLine("Using proxy to defer expensive loading...\n");

IImage image = new ImageProxy("photo1.jpg");
Console.WriteLine("Proxy created. Image not loaded yet.\n");

image.Display();
Console.WriteLine();
image.Display();

Console.WriteLine("\nThe real image loads only when first displayed.");

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

// Proxy controls access to the real subject and adds lazy loading.
public class ImageProxy : IImage
{
    private readonly string _fileName;
    private RealImage? _realImage;

    public ImageProxy(string fileName) => _fileName = fileName;

    public void Display()
    {
        if (_realImage is null)
        {
            _realImage = new RealImage(_fileName);
        }

        _realImage.Display();
    }
}
