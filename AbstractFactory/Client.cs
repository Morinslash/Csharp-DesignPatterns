namespace AbstractFactory;

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private int _orderCosts;
    public ShoppingCart(IShoppingCartPurchaseFactory shoppingCartPurchaseFactory)
    {
        _discountService = shoppingCartPurchaseFactory.CreateDiscountService();
        _shippingCostsService = shoppingCartPurchaseFactory.CreateShippingCostsService();
        _orderCosts = 200;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs: " +
                          $"{ _orderCosts - (_orderCosts/100  * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}