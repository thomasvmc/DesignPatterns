using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Lemon : CondimentDecorator
{
    public Lemon(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.30;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Lemon";
    }
    
}