using DesignPatternStrategyDemo.ScenarioOneAndTwo.Strategies.SalesTaxStrategy;

namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

public class Order
{
    private readonly ISalesTaxStrategy _taxStrategy;

    public Order(ShippingDetails shippingDetails, decimal price, ISalesTaxStrategy taxStrategy)
    {
        _taxStrategy = taxStrategy;
        ShippingDetails = shippingDetails;
        Price = price;
    }

    public ShippingDetails ShippingDetails { get; set; }
    public decimal Price { get; set; }

    public decimal GetTax()
    {
        var tax = _taxStrategy.GetTaxFor(this);
        return tax > 0 ? tax : throw new Exception("I can't calculate tax");
    }

    public string GetShippingDestinationCountry() => ShippingDetails.DestinationCountry.ToLowerInvariant();
    public string GetShippingOriginCountry() => ShippingDetails.OriginCountry.ToLowerInvariant();
    public bool HasShippingDestinationState() => ShippingDetails.DestinationState is not null;
    public string GetShippingDestinationState() => ShippingDetails.DestinationState!.ToLowerInvariant();

    public override string ToString() => $"{nameof(Price)}: {Price}, {nameof(ShippingDetails)}: {ShippingDetails}";
}
