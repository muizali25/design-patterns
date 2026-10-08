Console.WriteLine("================================");
Console.WriteLine("    BUILDER PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var pizza = new PizzaBuilder()
    .SetSize("Large")
    .AddCheese()
    .AddMushrooms()
    .SetSpecialInstructions("Extra cheese")
    .Build();

pizza.Describe();

Console.WriteLine("\nThe pizza is built step-by-step with a readable fluent API.");

public class Pizza
{
    public string Size { get; init; } = "Medium";
    public bool Cheese { get; init; }
    public bool Pepperoni { get; init; }
    public bool Mushrooms { get; init; }
    public bool Onions { get; init; }
    public string SpecialInstructions { get; init; } = string.Empty;

    public void Describe()
    {
        Console.WriteLine($"Pizza: {Size}, Cheese={Cheese}, Pepperoni={Pepperoni}, Mushrooms={Mushrooms}, Onions={Onions}");
        Console.WriteLine($"Notes: {SpecialInstructions}");
    }
}

// Builder constructs the object step-by-step.
public class PizzaBuilder
{
    private string _size = "Medium";
    private bool _cheese;
    private bool _pepperoni;
    private bool _mushrooms;
    private bool _onions;
    private string _specialInstructions = string.Empty;

    public PizzaBuilder SetSize(string size) { _size = size; return this; }
    public PizzaBuilder AddCheese() { _cheese = true; return this; }
    public PizzaBuilder AddPepperoni() { _pepperoni = true; return this; }
    public PizzaBuilder AddMushrooms() { _mushrooms = true; return this; }
    public PizzaBuilder AddOnions() { _onions = true; return this; }
    public PizzaBuilder SetSpecialInstructions(string notes) { _specialInstructions = notes; return this; }

    public Pizza Build() => new()
    {
        Size = _size,
        Cheese = _cheese,
        Pepperoni = _pepperoni,
        Mushrooms = _mushrooms,
        Onions = _onions,
        SpecialInstructions = _specialInstructions
    };
}
