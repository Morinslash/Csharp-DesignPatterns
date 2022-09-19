namespace AbstractFactory;

public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
        => new BelgiumDiscountService();

    public IShippingCostsService CreateShippingCostsService()
        => new BelgiumShippingCostsService();
}

public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
        => new FranceDiscountService();

    public IShippingCostsService CreateShippingCostsService()
        => new FranceShippingCostsService();
}