using DesignPatternStrategyDemo.ScenarioThree.Strategies;

namespace DesignPatternStrategyDemo.ScenarioThree.Models;

// Notification.cs
public class Notification
{
    public INotificationStrategy? NotificationStrategy { get; set; }

    public Notification(string content, UserNotificationSettings settings)
    {
        Content = content;
        Settings = settings;
    }

    public string Content { get; set; }
    public UserNotificationSettings Settings { get; set; }

    public void Send()
    {
        if (NotificationStrategy == null) throw new ArgumentException("NotificationStrategy is require");
        NotificationStrategy.Send(this);
    }
}
