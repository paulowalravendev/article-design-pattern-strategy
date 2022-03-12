using DesignPatternStrategyDemo.ScenarioThree.Models;
using DesignPatternStrategyDemo.ScenarioThree.Strategies;

var notification1 = new Notification("Hello Strategy", new UserNotificationSettings(NotificationChannels.Email));
var notification2 = new Notification("Hello Strategy", new UserNotificationSettings(NotificationChannels.Sms));
var notification3 =
    new Notification("Hello Strategy", new UserNotificationSettings(NotificationChannels.PushNotification));

notification1.NotificationStrategy = new EmailNotificationStrategy();
notification2.NotificationStrategy = new SmsNotificationStrategy();
notification3.NotificationStrategy = new PushNotificationStrategy();

notification1.Send();
notification2.Send();
notification3.Send();
