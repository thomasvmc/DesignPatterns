using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Whiskey : CondimentDecorator
{
    public Whiskey(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.60;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Whiskey";
    }
    
}