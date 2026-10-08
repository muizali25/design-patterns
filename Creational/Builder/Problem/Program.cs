Console.WriteLine("================================");
Console.WriteLine("    BUILDER PATTERN - PROBLEM");
Console.WriteLine("================================\n");

// Problem: Constructor with many parameters is hard to read and use.
var pizza = new Pizza("Large", true, false, true, false, "Extra cheese");

pizza.Describe();

Console.WriteLine("\nProblem: Many constructor parameters are confusing.");
Console.WriteLine("Optional combinations become difficult to manage.");

public class Pizza
{
    public Pizza(string size, bool cheese, bool pepperoni, bool mushrooms, bool onions, string specialInstructions)
    {
        Size = size;
        Cheese = cheese;
        Pepperoni = pepperoni;
        Mushrooms = mushrooms;
        Onions = onions;
        SpecialInstructions = specialInstructions;
    }

    public string Size { get; }
    public bool Cheese { get; }
    public bool Pepperoni { get; }
    public bool Mushrooms { get; }
    public bool Onions { get; }
    public string SpecialInstructions { get; }

    public void Describe()
    {
        Console.WriteLine($"Pizza: {Size}, Cheese={Cheese}, Pepperoni={Pepperoni}, Mushrooms={Mushrooms}, Onions={Onions}");
        Console.WriteLine($"Notes: {SpecialInstructions}");
    }
}
