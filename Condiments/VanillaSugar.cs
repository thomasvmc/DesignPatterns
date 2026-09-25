using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class VanillaSugar : CondimentDecorator
{
    public VanillaSugar(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.55;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Vanilla sugar";
    }
}