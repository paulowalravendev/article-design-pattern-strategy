using DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Strategies.SalesTaxStrategy;

public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}
