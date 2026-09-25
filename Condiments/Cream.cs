using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Cream :  Beverage
{
    public Cream(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.56;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cream";
    }
}