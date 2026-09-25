using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class WhippedCream : CondimentDecorator
{
    public WhippedCream(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.65;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Whipped cream";
    }
}