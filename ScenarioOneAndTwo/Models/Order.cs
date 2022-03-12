namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

public class Order
{
    public Order(ShippingDetails shippingDetails, decimal price)
    {
        ShippingDetails = shippingDetails;
        Price = price;
    }

    public ShippingDetails ShippingDetails { get; set; }
    public decimal Price { get; set; }

    public decimal GetTax()
    {
        var destination = GetShippingDestinationCountry();
        var origin = GetShippingOriginCountry();
        if (destination == "sweden")
        {
            if (destination == origin)
            {
                return Price * .25m;
            }

            return 0;
        }

        if (destination == "us")
        {
            if (HasShippingDestinationState() == false)
            {
                throw new ArgumentException("For calculate US tax destination state is requirement");
            }

            switch (GetShippingDestinationState())
            {
                case "la": return Price * 0.095m;
                case "ny": return Price * 0.04m;
                case "nyc": return Price * 0.045m;
                default: throw new ArgumentException("Invalid destination state for US tax");
            }
        }

        throw new NotImplementedException("Only calculate tax from US and Sweden");
    }

    public string GetShippingDestinationCountry() => ShippingDetails.DestinationCountry.ToLowerInvariant();
    public string GetShippingOriginCountry() => ShippingDetails.OriginCountry.ToLowerInvariant();
    public bool HasShippingDestinationState() => ShippingDetails.DestinationState is not null;
    public string GetShippingDestinationState() => ShippingDetails.DestinationState!.ToLowerInvariant();

    public override string ToString() => $"{nameof(Price)}: {Price}, {nameof(ShippingDetails)}: {ShippingDetails}";
}
