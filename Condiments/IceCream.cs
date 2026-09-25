using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class IceCream : CondimentDecorator
{
    public IceCream(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.75;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Ice cream";
    }
}