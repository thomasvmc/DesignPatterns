using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Liquor : CondimentDecorator
{
    public Liquor(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.70;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Liquor";
    }
    
}