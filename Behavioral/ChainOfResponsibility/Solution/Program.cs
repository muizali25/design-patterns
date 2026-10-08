Console.WriteLine("================================");
Console.WriteLine("CHAIN OF RESPONSIBILITY - SOLUTION");
Console.WriteLine("================================\n");

var supervisor = new SupervisorHandler();
var manager = new ManagerHandler();
var director = new DirectorHandler();

supervisor.SetNext(manager).SetNext(director);

supervisor.Handle(200);
supervisor.Handle(2000);
supervisor.Handle(15000);

Console.WriteLine("\nEach handler decides whether to process or pass the request.");

public abstract class ApprovalHandler
{
    private ApprovalHandler? _next;

    public ApprovalHandler SetNext(ApprovalHandler next)
    {
        _next = next;
        return next;
    }

    public void Handle(decimal amount)
    {
        if (CanHandle(amount))
        {
            Process(amount);
        }
        else if (_next is not null)
        {
            _next.Handle(amount);
        }
        else
        {
            Console.WriteLine($"No handler found for ${amount}.");
        }
    }

    protected abstract bool CanHandle(decimal amount);
    protected abstract void Process(decimal amount);
}

public class SupervisorHandler : ApprovalHandler
{
    protected override bool CanHandle(decimal amount) => amount <= 500;
    protected override void Process(decimal amount) =>
        Console.WriteLine($"Supervisor approved ${amount}.");
}

public class ManagerHandler : ApprovalHandler
{
    protected override bool CanHandle(decimal amount) => amount <= 5000;
    protected override void Process(decimal amount) =>
        Console.WriteLine($"Manager approved ${amount}.");
}

public class DirectorHandler : ApprovalHandler
{
    protected override bool CanHandle(decimal amount) => amount <= 50000;
    protected override void Process(decimal amount) =>
        Console.WriteLine($"Director approved ${amount}.");
}
