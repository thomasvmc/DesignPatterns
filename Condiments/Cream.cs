using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Cream :  Beverage
{
    public Cream(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.56 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cream";
    }
}