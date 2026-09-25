using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Chocolate : CondimentDecorator
{
    public Chocolate(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.45;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Chocolate";
    }
}