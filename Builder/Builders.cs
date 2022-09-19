namespace Builder;

public abstract class CarBuilder
{
    public Car Car { get; private set; }
    public CarBuilder(string carType)
    {
        Car = new(carType);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}

public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("'not a v8'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'3-door with stripes'");
    }
}

public class BmwBuilder : CarBuilder
{
    public BmwBuilder() : base("Bmw")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("'a fancy v8 engine'");
    }

    public override void BuildFrame()
    {
        Car.AddPart("'5-door with metallic finish'");
    }
}
