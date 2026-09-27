using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class BlackChocolate : CondimentDecorator
{
    public BlackChocolate(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.45;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Black chocolate";
    }
}