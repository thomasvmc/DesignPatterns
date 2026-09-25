using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Ice : CondimentDecorator
{
    public Ice(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.05;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Ice";
    }
}