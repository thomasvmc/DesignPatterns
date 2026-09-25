using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class MilkFoam : CondimentDecorator
{
    public MilkFoam(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.35;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Milk foam";
    }
}