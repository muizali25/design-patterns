Console.WriteLine("================================");
Console.WriteLine("   DECORATOR PATTERN - SOLUTION");
Console.WriteLine("================================\n");

ICoffee coffee = new PlainCoffee();
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);

Console.WriteLine($"{coffee.Description} - ${coffee.Cost:F2}");

Console.WriteLine("\nAdd-ons wrap the coffee dynamically without new subclasses.");

public interface ICoffee
{
    string Description { get; }
    decimal Cost { get; }
}

public class PlainCoffee : ICoffee
{
    public string Description => "Plain coffee";
    public decimal Cost => 2.00m;
}

public abstract class CoffeeDecorator : ICoffee
{
    protected CoffeeDecorator(ICoffee coffee) => Coffee = coffee;

    protected ICoffee Coffee { get; }

    public virtual string Description => Coffee.Description;
    public virtual decimal Cost => Coffee.Cost;
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string Description => Coffee.Description + ", milk";
    public override decimal Cost => Coffee.Cost + 0.50m;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string Description => Coffee.Description + ", sugar";
    public override decimal Cost => Coffee.Cost + 0.30m;
}
