Console.WriteLine("================================");
Console.WriteLine("     FACADE PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var amplifier = new Amplifier();
var projector = new Projector();
var lights = new Lights();

Console.WriteLine("Client must orchestrate every subsystem manually:\n");

amplifier.On();
projector.On();
projector.SetInput("HDMI");
lights.Dim(30);

Console.WriteLine("\nProblem: Client knows too much about subsystem details.");
Console.WriteLine("Starting a movie requires many coordinated steps.");

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
