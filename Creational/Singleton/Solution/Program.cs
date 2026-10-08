Console.WriteLine("================================");
Console.WriteLine("   SINGLETON PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var settingsFromUi = AppSettings.Instance;
settingsFromUi.Theme = "Dark";

var settingsFromService = AppSettings.Instance;

Console.WriteLine($"UI settings theme: {settingsFromUi.Theme}");
Console.WriteLine($"Service settings theme: {settingsFromService.Theme}");
Console.WriteLine($"Same instance? {ReferenceEquals(settingsFromUi, settingsFromService)}");

Console.WriteLine("\nThe app now shares one AppSettings instance.");
Console.WriteLine("All parts of the app see the same configuration.");

// Singleton ensures only one shared instance exists.
public sealed class AppSettings
{
    private static readonly Lazy<AppSettings> _instance = new(() => new AppSettings());

    public static AppSettings Instance => _instance.Value;

    private AppSettings() { }

    public string Theme { get; set; } = "Default";
}
