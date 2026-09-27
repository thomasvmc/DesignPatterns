using DecoratorPattern.Beverages;

namespace DecoratorPattern.Beverages;

internal class Chocolate : BaseBeverage
{
    public Chocolate(SizeEnum? size, Beverage? beverage = null) : base(size, beverage)
    {
        description = "Chocolate";
        this.baseBeverage = beverage;
        Cost = 0.45;
    }
    
    public override string GetDescription()
    {
        if (baseBeverage != null)
        {
            return baseBeverage.GetDescription() + ", " + description;
        }
        return description;
    }
}