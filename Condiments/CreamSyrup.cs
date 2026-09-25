using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class CreamSyrup : CondimentDecorator
{
    public CreamSyrup(Beverage beverage)
    {
        this.baseBeverage = beverage;
        Cost = 0.49;
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cream and syrup";
    }
}