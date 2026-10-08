Console.WriteLine("================================");
Console.WriteLine("CHAIN OF RESPONSIBILITY - PROBLEM");
Console.WriteLine("================================\n");

var approver = new PurchaseApprover();

approver.Approve(200);
approver.Approve(2000);
approver.Approve(15000);

Console.WriteLine("\nProblem: One class handles every approval level with if/else.");
Console.WriteLine("Adding a new level requires modifying existing logic.");

public class PurchaseApprover
{
    public void Approve(decimal amount)
    {
        if (amount <= 500)
        {
            Console.WriteLine($"Supervisor approved ${amount}.");
        }
        else if (amount <= 5000)
        {
            Console.WriteLine($"Manager approved ${amount}.");
        }
        else
        {
            Console.WriteLine($"Director approved ${amount}.");
        }
    }
}
