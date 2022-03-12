using DesignPatternStrategyDemo.ScenarioThree.Models;

namespace DesignPatternStrategyDemo.ScenarioThree.Strategies;

public interface INotificationStrategy
{
    void Send(Notification notification);
}
