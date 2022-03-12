using DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Strategies.SalesTaxStrategy;

public class SwedenSalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        var destination = order.GetShippingDestinationCountry();
        var origin = order.GetShippingOriginCountry();
        if (destination == origin)
        {
            return order.Price * .25m;
        }

        return 0;
    }
}
