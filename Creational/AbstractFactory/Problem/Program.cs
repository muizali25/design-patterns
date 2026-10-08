Console.WriteLine("================================");
Console.WriteLine("ABSTRACT FACTORY PATTERN - PROBLEM");
Console.WriteLine("================================\n");

// Problem: Client mixes components from different themes.
var button = new DarkButton();
var checkbox = new LightCheckbox();

button.Render();
checkbox.Render();

Console.WriteLine("\nProblem: Components from different themes can be combined.");
Console.WriteLine("The UI can look inconsistent and invalid.");

public class DarkButton
{
    public void Render() => Console.WriteLine("Rendering dark button...");
}

public class LightCheckbox
{
    public void Render() => Console.WriteLine("Rendering light checkbox...");
}
