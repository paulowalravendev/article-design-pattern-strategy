using DesignPatternStrategyDemo.ScenarioThree.Models;

namespace DesignPatternStrategyDemo.ScenarioThree.Strategies;

public class EmailNotificationStrategy : INotificationStrategy
{
    public void Send(Notification notification)
    {
        if (notification.Settings.EnableNotification == false)
        {
            Console.WriteLine("Cannot send notification because the user has disabled");
        }

        if (notification.Settings.NotificationChanel != NotificationChannels.Email)
        {
            throw new ApplicationException("Strategy is wrong");
        }

        Console.WriteLine($"Send notification: \"{notification.Content}\" by email");
    }
}
