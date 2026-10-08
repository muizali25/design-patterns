Console.WriteLine("================================");
Console.WriteLine("    ADAPTER PATTERN - SOLUTION");
Console.WriteLine("================================\n");

IPrinter printer = new LegacyPrinterAdapter(new LegacyPrinter());
var client = new PrintClient();

client.PrintDocument(printer, "Design Patterns Report");

Console.WriteLine("\nThe adapter converts LegacyPrinter into IPrinter.");
Console.WriteLine("The client can now use the legacy class without changes.");

public interface IPrinter
{
    void Print(string document);
}

public class PrintClient
{
    public void PrintDocument(IPrinter printer, string document)
    {
        printer.Print(document);
    }
}

public class LegacyPrinter
{
    public void PrintDocument(string text)
    {
        Console.WriteLine($"Legacy printer output: {text}");
    }
}

// Adapter wraps the legacy class and exposes the expected interface.
public class LegacyPrinterAdapter : IPrinter
{
    private readonly LegacyPrinter _legacyPrinter;

    public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
    {
        _legacyPrinter = legacyPrinter;
    }

    public void Print(string document)
    {
        _legacyPrinter.PrintDocument(document);
    }
}
