namespace DesignPatternStrategyDemo.ScenarioThree.Models;


public class UserNotificationSettings
{
    public UserNotificationSettings(NotificationChannels notificationChanel)
    {
        NotificationChanel = notificationChanel;
        EnableNotification = true;
    }

    public NotificationChannels NotificationChanel { get; set; }
    public bool EnableNotification { get; set; }
}
