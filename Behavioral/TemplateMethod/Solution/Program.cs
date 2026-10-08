Console.WriteLine("================================");
Console.WriteLine(" TEMPLATE METHOD PATTERN - SOLUTION");
Console.WriteLine("================================\n");

DataExporter csvExporter = new CsvExporter();
csvExporter.Export();

Console.WriteLine();

DataExporter jsonExporter = new JsonExporter();
jsonExporter.Export();

Console.WriteLine("\nThe shared export workflow is defined once in the base class.");

public abstract class DataExporter
{
    // Template method defines the skeleton of the algorithm.
    public void Export()
    {
        Connect();
        ReadData();
        WriteFormat();
        Disconnect();
    }

    private void Connect() => Console.WriteLine("Connecting to data source...");
    private void ReadData() => Console.WriteLine("Reading records...");
    protected abstract void WriteFormat();
    private void Disconnect() => Console.WriteLine("Closing connection...");
}

public class CsvExporter : DataExporter
{
    protected override void WriteFormat() =>
        Console.WriteLine("Exporting data as CSV...");
}

public class JsonExporter : DataExporter
{
    protected override void WriteFormat() =>
        Console.WriteLine("Exporting data as JSON...");
}
