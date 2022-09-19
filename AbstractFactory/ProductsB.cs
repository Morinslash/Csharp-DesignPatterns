namespace AbstractFactory;

public interface IShippingCostsService
{
  decimal ShippingCosts { get; }
}

public class BelgiumShippingCostsService : IShippingCostsService
{
  public decimal ShippingCosts => 20;
}

public class FranceShippingCostsService : IShippingCostsService
{
  public decimal ShippingCosts => 25;
}