Console.WriteLine("================================");
Console.WriteLine("   SINGLETON PATTERN - PROBLEM");
Console.WriteLine("================================\n");

// Problem: Each part of the app creates its own AppSettings instance.
// Settings can become inconsistent across the application.

var settingsFromUi = new AppSettings();
settingsFromUi.Theme = "Dark";

var settingsFromService = new AppSettings();
settingsFromService.Theme = "Light";

Console.WriteLine($"UI settings theme: {settingsFromUi.Theme}");
Console.WriteLine($"Service settings theme: {settingsFromService.Theme}");
Console.WriteLine($"Same instance? {ReferenceEquals(settingsFromUi, settingsFromService)}");

Console.WriteLine("\nProblem: Multiple instances can hold different values.");
Console.WriteLine("There is no single shared source of truth.");

public class AppSettings
{
    public string Theme { get; set; } = "Default";
}
