using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class WhippedCream : CondimentDecorator
{
    public WhippedCream(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.65 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Whipped cream";
    }
}