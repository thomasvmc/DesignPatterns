using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Honey :  Beverage
{
    public Honey(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.25;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Honey";
    }
}