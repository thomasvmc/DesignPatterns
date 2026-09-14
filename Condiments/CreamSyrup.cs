using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class CreamSyrup : CondimentDecorator
{
    public CreamSyrup(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.49 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cream and syrup";
    }
}