using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class WhiteChocolate : CondimentDecorator
{
    public WhiteChocolate(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.45;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", White chocolate";
    }
}