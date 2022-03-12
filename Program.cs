using DesignPatternStrategyDemo.ScenarioOneAndTwo.Models;
using DesignPatternStrategyDemo.ScenarioOneAndTwo.Strategies.SalesTaxStrategy;

// Scenario 1 e 2:
// Contexto: Order

var order1 = new Order(
    new ShippingDetails("Sweden", "Sweden"), 100, new SwedenSalesTaxStrategy());
Console.WriteLine("INFO: {0}", order1);
Console.WriteLine($"Calculate Order1 Tax: USD: {order1.GetTax()}");

var order2 = new Order(new ShippingDetails(
    "Sweden", "US", "NYC"), 100, new UsSalesTaxStrategy());
Console.WriteLine("INFO: {0}", order2);
Console.WriteLine($"Calculate Order2 Tax: USD: {order2.GetTax()}");
