using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class HalfMilk :  Beverage
{
    public HalfMilk(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.27 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", 1/2 milk";
    }
}