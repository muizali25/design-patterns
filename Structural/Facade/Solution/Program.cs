Console.WriteLine("================================");
Console.WriteLine("     FACADE PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var homeTheater = new HomeTheaterFacade(
    new Amplifier(),
    new Projector(),
    new Lights());

homeTheater.WatchMovie();

Console.WriteLine("\nOne simple method hides the complexity of multiple subsystems.");

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier on.");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector on.");
    public void SetInput(string input) => Console.WriteLine($"Projector input set to {input}.");
}

public class Lights
{
    public void Dim(int level) => Console.WriteLine($"Lights dimmed to {level}%.");
}

// Facade provides a simple interface to a complex subsystem.
public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier;
    private readonly Projector _projector;
    private readonly Lights _lights;

    public HomeTheaterFacade(Amplifier amplifier, Projector projector, Lights lights)
    {
        _amplifier = amplifier;
        _projector = projector;
        _lights = lights;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Starting movie mode...\n");
        _amplifier.On();
        _projector.On();
        _projector.SetInput("HDMI");
        _lights.Dim(30);
        Console.WriteLine("\nMovie mode ready.");
    }
}
