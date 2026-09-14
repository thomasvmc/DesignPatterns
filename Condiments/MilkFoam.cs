using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class MilkFoam : CondimentDecorator
{
    public MilkFoam(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.35 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Milk foam";
    }
}