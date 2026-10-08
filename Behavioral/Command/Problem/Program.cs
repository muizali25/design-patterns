Console.WriteLine("================================");
Console.WriteLine("     COMMAND PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var remote = new RemoteControl();
var light = new Light();

remote.TurnLightOn(light);
remote.TurnLightOff(light);

Console.WriteLine("\nProblem: RemoteControl is tightly coupled to Light operations.");
Console.WriteLine("Actions cannot be stored, queued, or undone easily.");

public class Light
{
    public void TurnOn() => Console.WriteLine("Light is ON.");
    public void TurnOff() => Console.WriteLine("Light is OFF.");
}

public class RemoteControl
{
    public void TurnLightOn(Light light) => light.TurnOn();
    public void TurnLightOff(Light light) => light.TurnOff();
}
