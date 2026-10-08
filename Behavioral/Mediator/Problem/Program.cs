Console.WriteLine("================================");
Console.WriteLine("    MEDIATOR PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var alice = new ChatUser("Alice");
var bob = new ChatUser("Bob");

alice.SendDirectMessage(bob, "Hello Bob!");
bob.SendDirectMessage(alice, "Hi Alice!");

Console.WriteLine("\nProblem: Users communicate directly with each other.");
Console.WriteLine("Adding more users creates many direct connections.");

public class ChatUser
{
    public ChatUser(string name) => Name = name;
    public string Name { get; }

    public void SendDirectMessage(ChatUser recipient, string message)
    {
        Console.WriteLine($"{Name} -> {recipient.Name}: {message}");
    }
}
