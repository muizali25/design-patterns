Console.WriteLine("================================");
Console.WriteLine("    MEDIATOR PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var mediator = new ChatMediator();
var alice = new ChatUser("Alice", mediator);
var bob = new ChatUser("Bob", mediator);

alice.Send("Hello everyone!");
bob.Send("Hi Alice!");

Console.WriteLine("\nUsers talk through a mediator instead of directly to each other.");

public class ChatMediator
{
    private readonly List<ChatUser> _users = new();

    public void Register(ChatUser user) => _users.Add(user);

    public void SendMessage(string from, string message)
    {
        foreach (var user in _users)
        {
            if (user.Name != from)
            {
                user.Receive(from, message);
            }
        }
    }
}

public class ChatUser
{
    private readonly ChatMediator _mediator;

    public ChatUser(string name, ChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
        _mediator.Register(this);
    }

    public string Name { get; }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _mediator.SendMessage(Name, message);
    }

    public void Receive(string from, string message) =>
        Console.WriteLine($"{Name} received from {from}: {message}");
}
