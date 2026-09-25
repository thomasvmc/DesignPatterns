using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Cocoa : CondimentDecorator
{
    public Cocoa(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.30;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cocoa";
    }
}