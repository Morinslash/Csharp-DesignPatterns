namespace Facade;

public class OrderService
{
    public bool HasEnoughOrders(int customerId) => (customerId > 5);
}

public class CustomerDiscountBaseService
{
    public double CalculateDiscountBase(int customerId) => (customerId > 8) ? 10 : 20;
}

public class DayOfTheWeekFactorService
{
    public double CalculateDayOfTheWeekFactor() =>
        DateTime.UtcNow.DayOfWeek switch
        {
            DayOfWeek.Saturday => 0.8,
            DayOfWeek.Sunday => 0.8,
            _ => 1.2
        };
}