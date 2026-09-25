using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class HalfMilk :  Beverage
{
    public HalfMilk(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.27;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", 1/2 milk";
    }
}