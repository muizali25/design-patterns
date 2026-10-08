Console.WriteLine("================================");
Console.WriteLine("    OBSERVER PATTERN - SOLUTION");
Console.WriteLine("================================\n");

var agency = new NewsAgency();
agency.Subscribe(new EmailSubscriber("alice@example.com"));
agency.Subscribe(new SmsSubscriber("+123456789"));

agency.PublishNews("New design patterns course released!");

Console.WriteLine("\nSubject notifies all observers through a common interface.");

public interface IObserver
{
    void Update(string news);
}

public class NewsAgency
{
    private readonly List<IObserver> _observers = new();

    public void Subscribe(IObserver observer) => _observers.Add(observer);

    public void PublishNews(string news)
    {
        Console.WriteLine($"\nPublishing news: {news}\n");

        foreach (var observer in _observers)
        {
            observer.Update(news);
        }
    }
}

public class EmailSubscriber : IObserver
{
    public EmailSubscriber(string email) => Email = email;
    public string Email { get; }

    public void Update(string news) =>
        Console.WriteLine($"Sending email to {Email}: {news}");
}

public class SmsSubscriber : IObserver
{
    public SmsSubscriber(string phone) => Phone = phone;
    public string Phone { get; }

    public void Update(string news) =>
        Console.WriteLine($"Sending SMS to {Phone}: {news}");
}
