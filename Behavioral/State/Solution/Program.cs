Console.WriteLine("================================");
Console.WriteLine("      STATE PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var machine = new VendingMachine(new IdleState());

machine.InsertCoin();
machine.SelectProduct();
machine.Dispense();

Console.WriteLine("\nEach state encapsulates its own behavior and transitions.");

public interface IState
{
    void InsertCoin(VendingMachine machine);
    void SelectProduct(VendingMachine machine);
    void Dispense(VendingMachine machine);
}

public class VendingMachine
{
    public VendingMachine(IState state) => State = state;

    public IState State { get; set; }

    public void InsertCoin() => State.InsertCoin(this);
    public void SelectProduct() => State.SelectProduct(this);
    public void Dispense() => State.Dispense(this);
}

public class IdleState : IState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("Coin inserted.");
        machine.State = new HasCoinState();
    }

    public void SelectProduct(VendingMachine machine) =>
        Console.WriteLine("Insert a coin first.");

    public void Dispense(VendingMachine machine) =>
        Console.WriteLine("Cannot dispense yet.");
}

public class HasCoinState : IState
{
    public void InsertCoin(VendingMachine machine) =>
        Console.WriteLine("Coin already inserted.");

    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("Product selected.");
        machine.State = new DispensingState();
    }

    public void Dispense(VendingMachine machine) =>
        Console.WriteLine("Select a product first.");
}

public class DispensingState : IState
{
    public void InsertCoin(VendingMachine machine) =>
        Console.WriteLine("Please wait for dispensing to finish.");

    public void SelectProduct(VendingMachine machine) =>
        Console.WriteLine("Product already selected.");

    public void Dispense(VendingMachine machine)
    {
        Console.WriteLine("Dispensing product...");
        machine.State = new IdleState();
    }
}
