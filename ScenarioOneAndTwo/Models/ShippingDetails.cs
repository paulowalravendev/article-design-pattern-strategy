namespace DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;

public class ShippingDetails
{
    public ShippingDetails(string originCountry, string destinationCountry, string? destinationState)
    {
        OriginCountry = originCountry;
        DestinationCountry = destinationCountry;
        DestinationState = destinationState;
    }

    public ShippingDetails(string originCountry, string destinationCountry)
    {
        OriginCountry = originCountry;
        DestinationCountry = destinationCountry;
    }

    public string OriginCountry { get; set; }
    public string DestinationCountry { get; set; }
    public string? DestinationState { get; set; }

    public override string ToString() =>
        $"{nameof(OriginCountry)}: {OriginCountry}, {nameof(DestinationCountry)}: {DestinationCountry} " +
        $"{(DestinationState != null ? $", {nameof(DestinationState)}: {DestinationState}" : "")}";
}
