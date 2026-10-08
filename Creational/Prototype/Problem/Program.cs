Console.WriteLine("================================");
Console.WriteLine("   PROTOTYPE PATTERN - PROBLEM");
Console.WriteLine("================================\n");

Console.WriteLine("Creating reports from scratch each time...\n");

for (int i = 1; i <= 3; i++)
{
    var report = new Report();
    report.InitializeDefaults();
    report.Title = $"Report #{i}";
    report.Print();
}

Console.WriteLine("\nProblem: Expensive setup runs repeatedly for similar objects.");
Console.WriteLine("Creating from scratch is slow and duplicates work.");

public class Report
{
    public string Title { get; set; } = "Untitled";
    public List<string> Sections { get; set; } = new();

    public void InitializeDefaults()
    {
        Console.WriteLine("Loading default template...");
        Console.WriteLine("Applying company formatting...");
        Sections = new List<string> { "Summary", "Details", "Appendix" };
    }

    public void Print() => Console.WriteLine($"Printing report: {Title}");
}
