using DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Strategies.SalesTaxStrategy;

public class UsSalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        if (order.HasShippingDestinationState() == false)
        {
            throw new ArgumentException("For calculate US tax destination state is requirement");
        }

        switch (order.GetShippingDestinationState())
        {
            case "la": return order.Price * 0.095m;
            case "ny": return order.Price * 0.04m;
            case "nyc": return order.Price * 0.045m;
            default: return 0;
        }
    }
}