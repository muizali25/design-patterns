Console.WriteLine("================================");
Console.WriteLine("    ADAPTER PATTERN - PROBLEM");
Console.WriteLine("================================\n");

// Client expects IPrinter, but only a legacy printer exists.
var client = new PrintClient();

Console.WriteLine("Client wants to print using IPrinter...");
Console.WriteLine("Problem: LegacyPrinter has a different interface.");
Console.WriteLine("The client cannot use LegacyPrinter directly.");

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
