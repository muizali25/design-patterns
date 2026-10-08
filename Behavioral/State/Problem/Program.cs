Console.WriteLine("================================");
Console.WriteLine("      STATE PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var machine = new VendingMachine();

machine.InsertCoin();
machine.SelectProduct();
machine.Dispense();

Console.WriteLine("\nProblem: VendingMachine behavior changes with a large switch on state.");
Console.WriteLine("State transitions and actions are mixed in one class.");

public class VendingMachine
{
    private string _state = "Idle";

    public void InsertCoin()
    {
        if (_state == "Idle")
        {
            Console.WriteLine("Coin inserted.");
            _state = "HasCoin";
        }
        else
        {
            Console.WriteLine("Coin already inserted.");
        }
    }

    public void SelectProduct()
    {
        if (_state == "HasCoin")
        {
            Console.WriteLine("Product selected.");
            _state = "Dispensing";
        }
        else
        {
            Console.WriteLine("Insert a coin first.");
        }
    }

    public void Dispense()
    {
        if (_state == "Dispensing")
        {
            Console.WriteLine("Dispensing product...");
            _state = "Idle";
        }
        else
        {
            Console.WriteLine("Cannot dispense yet.");
        }
    }
}
