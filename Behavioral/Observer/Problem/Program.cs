Console.WriteLine("================================");
Console.WriteLine("    OBSERVER PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var agency = new NewsAgency();
var emailSub = new EmailSubscriber("alice@example.com");
var smsSub = new SmsSubscriber("+123456789");

agency.Subscribers.Add(emailSub);
agency.Subscribers.Add(smsSub);

agency.PublishNews("New design patterns course released!");

Console.WriteLine("\nProblem: NewsAgency manually tracks and notifies each subscriber type.");
Console.WriteLine("Adding a new subscriber type changes NewsAgency.");

public class NewsAgency
{
    public List<object> Subscribers { get; } = new();
    public string LatestNews { get; private set; } = string.Empty;

    public void PublishNews(string news)
    {
        LatestNews = news;
        Console.WriteLine($"\nPublishing news: {news}\n");

        foreach (var subscriber in Subscribers)
        {
            if (subscriber is EmailSubscriber email)
            {
                email.SendEmail(news);
            }
            else if (subscriber is SmsSubscriber sms)
            {
                sms.SendSms(news);
            }
        }
    }
}

public class EmailSubscriber
{
    public EmailSubscriber(string email) => Email = email;
    public string Email { get; }

    public void SendEmail(string news) =>
        Console.WriteLine($"Sending email to {Email}: {news}");
}

public class SmsSubscriber
{
    public SmsSubscriber(string phone) => Phone = phone;
    public string Phone { get; }

    public void SendSms(string news) =>
        Console.WriteLine($"Sending SMS to {Phone}: {news}");
}
