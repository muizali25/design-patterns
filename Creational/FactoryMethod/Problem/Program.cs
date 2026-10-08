Console.WriteLine("================================");
Console.WriteLine(" FACTORY METHOD PATTERN - PROBLEM");
Console.WriteLine("================================\n");

var service = new NotificationService();

service.Send("email");
service.Send("sms");
service.Send("push");

Console.WriteLine("\nProblem: NotificationService must know every notification type.");
Console.WriteLine("Adding a new type requires changing this class.");

public class NotificationService
{
    public void Send(string type)
    {
        if (type == "email")
        {
            Console.WriteLine("Sending email notification...");
        }
        else if (type == "sms")
        {
            Console.WriteLine("Sending SMS notification...");
        }
        else if (type == "push")
        {
            Console.WriteLine("Sending push notification...");
        }
        else
        {
            Console.WriteLine("Unknown notification type.");
        }
    }
}
