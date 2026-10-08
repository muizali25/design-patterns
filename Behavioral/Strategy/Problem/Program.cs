Console.WriteLine("================================");
Console.WriteLine("    STRATEGY PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var processor = new PaymentProcessor();

processor.Process("creditcard");
processor.Process("cash");
processor.Process("paypal");

Console.WriteLine("\nProblem: PaymentProcessor contains payment logic for every method.");
Console.WriteLine("Adding a new payment type requires modifying this class.");

public class PaymentProcessor
{
    public void Process(string paymentType)
    {
        Console.WriteLine($"Selected payment: {paymentType}");

        if (paymentType == "creditcard")
        {
            Console.WriteLine("Processing credit card payment...");
        }
        else if (paymentType == "cash")
        {
            Console.WriteLine("Processing cash payment...");
        }
        else if (paymentType == "paypal")
        {
            Console.WriteLine("Processing PayPal payment...");
        }
        else
        {
            Console.WriteLine("Unknown payment type.");
        }
    }
}
