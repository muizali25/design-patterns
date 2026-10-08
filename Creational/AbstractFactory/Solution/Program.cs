Console.WriteLine("================================");
Console.WriteLine("ABSTRACT FACTORY PATTERN - SOLUTION");
Console.WriteLine("================================\n");

Console.WriteLine("Dark Theme:");
IGUIFactory darkFactory = new DarkThemeFactory();
RenderUi(darkFactory);

Console.WriteLine("\nLight Theme:");
IGUIFactory lightFactory = new LightThemeFactory();
RenderUi(lightFactory);

Console.WriteLine("\nEach factory creates a matching family of UI components.");

static void RenderUi(IGUIFactory factory)
{
    factory.CreateButton().Render();
    factory.CreateCheckbox().Render();
}

public interface IButton { void Render(); }
public interface ICheckbox { void Render(); }

public class DarkButton : IButton
{
    public void Render() => Console.WriteLine("Rendering dark button...");
}

public class DarkCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering dark checkbox...");
}

public class LightButton : IButton
{
    public void Render() => Console.WriteLine("Rendering light button...");
}

public class LightCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering light checkbox...");
}

// Abstract factory ensures compatible product families.
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class DarkThemeFactory : IGUIFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}

public class LightThemeFactory : IGUIFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}
