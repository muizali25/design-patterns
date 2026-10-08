Console.WriteLine("================================");
Console.WriteLine("   DECORATOR PATTERN - PROBLEM");
Console.WriteLine("================================\n");

ICoffee coffee = new CoffeeWithMilkAndSugar();
Console.WriteLine($"{coffee.Description} - ${coffee.Cost:F2}");

Console.WriteLine("\nProblem: Every add-on combination needs its own subclass.");
Console.WriteLine("CoffeeWithMilk, CoffeeWithSugar, CoffeeWithMilkAndSugar, etc.");

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

public class CoffeeWithMilkAndSugar : ICoffee
{
    public string Description => "Coffee with milk and sugar";
    public decimal Cost => 2.80m;
}
