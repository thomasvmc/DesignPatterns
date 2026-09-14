using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class WhiteChocolate : CondimentDecorator
{
    public WhiteChocolate(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.45 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", White chocolate";
    }
}