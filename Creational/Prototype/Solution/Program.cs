Console.WriteLine("================================");
Console.WriteLine("   PROTOTYPE PATTERN - SOLUTION");
Console.WriteLine("================================\n");

Console.WriteLine("Creating prototype once, then cloning...\n");

var prototype = new Report();
prototype.InitializeDefaults();
prototype.Title = "Monthly Report Template";

for (int i = 1; i <= 3; i++)
{
    var report = prototype.Clone();
    report.Title = $"Report #{i}";
    report.Print();
}

Console.WriteLine("\nCloning reuses expensive setup without repeating it.");

public interface IPrototype<T>
{
    T Clone();
}

public class Report : IPrototype<Report>
{
    public string Title { get; set; } = "Untitled";
    public List<string> Sections { get; set; } = new();

    public void InitializeDefaults()
    {
        Console.WriteLine("Loading default template...");
        Console.WriteLine("Applying company formatting...");
        Sections = new List<string> { "Summary", "Details", "Appendix" };
    }

    public Report Clone()
    {
        Console.WriteLine("Cloning existing report...");
        return new Report
        {
            Title = Title,
            Sections = new List<string>(Sections)
        };
    }

    public void Print() => Console.WriteLine($"Printing report: {Title}");
}
