namespace Bridge;

public abstract class Menu
{
    public abstract int CalculatePrice();
    public readonly ICoupon Coupon = null!;

    public Menu(ICoupon coupon)
    {
        Coupon = coupon;
    }
}

class MeatBasedMenu : Menu
{
    public MeatBasedMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice() => 30 - Coupon.CouponValue;
}

public class VegetarianMenu : Menu
{
    public VegetarianMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice() => 20 - Coupon.CouponValue;
}

