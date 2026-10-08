Console.WriteLine("================================");
Console.WriteLine("    STRATEGY PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var processor = new PaymentProcessor(new CreditCardStrategy());
processor.ProcessPayment();

processor.SetStrategy(new CashStrategy());
processor.ProcessPayment();

Console.WriteLine("\nThe behavior can now be changed without modifying PaymentProcessor.");

public interface IPaymentStrategy
{
    void Pay();
}

public class CreditCardStrategy : IPaymentStrategy
{
    public void Pay() => Console.WriteLine("Processing credit card payment...");
}

public class CashStrategy : IPaymentStrategy
{
    public void Pay() => Console.WriteLine("Processing cash payment...");
}

public class PaymentProcessor
{
    private IPaymentStrategy _strategy;

    public PaymentProcessor(IPaymentStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IPaymentStrategy strategy) => _strategy = strategy;

    public void ProcessPayment()
    {
        Console.WriteLine($"Selected Strategy: {_strategy.GetType().Name.Replace("Strategy", "")}\n");
        _strategy.Pay();
    }
}
