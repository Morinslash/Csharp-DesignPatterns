namespace AbstractFactory;

public interface IDiscountService
{
    int DiscountPercentage { get; }
}

public class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}