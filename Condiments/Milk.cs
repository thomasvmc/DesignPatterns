using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.20;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Milk";
    }
}