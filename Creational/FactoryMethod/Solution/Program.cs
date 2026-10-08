Console.WriteLine("================================");
Console.WriteLine(" FACTORY METHOD PATTERN - SOLUTION");
Console.WriteLine("================================\n");

NotificationCreator creator = new EmailNotificationCreator();
creator.SendNotification();

creator = new SmsNotificationCreator();
creator.SendNotification();

Console.WriteLine("\nObject creation is delegated to specialized creators.");
Console.WriteLine("NotificationService code no longer grows with every new type.");

// Product
public interface INotification
{
    void Send();
}

public class EmailNotification : INotification
{
    public void Send() => Console.WriteLine("Sending email notification...");
}

public class SmsNotification : INotification
{
    public void Send() => Console.WriteLine("Sending SMS notification...");
}

// Creator with factory method
public abstract class NotificationCreator
{
    public void SendNotification()
    {
        INotification notification = CreateNotification();
        notification.Send();
    }

    protected abstract INotification CreateNotification();
}

public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification() => new EmailNotification();
}

public class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification() => new SmsNotification();
}
