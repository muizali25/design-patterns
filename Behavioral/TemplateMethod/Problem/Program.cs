Console.WriteLine("================================");
Console.WriteLine(" TEMPLATE METHOD PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var csvExporter = new CsvExporter();
csvExporter.Export();

Console.WriteLine();

var jsonExporter = new JsonExporter();
jsonExporter.Export();

Console.WriteLine("\nProblem: Export steps are duplicated across exporter classes.");
Console.WriteLine("Shared workflow is repeated instead of defined once.");

public class CsvExporter
{
    public void Export()
    {
        Console.WriteLine("Connecting to data source...");
        Console.WriteLine("Reading records...");
        Console.WriteLine("Exporting data as CSV...");
        Console.WriteLine("Closing connection...");
    }
}

public class JsonExporter
{
    public void Export()
    {
        Console.WriteLine("Connecting to data source...");
        Console.WriteLine("Reading records...");
        Console.WriteLine("Exporting data as JSON...");
        Console.WriteLine("Closing connection...");
    }
}
