namespace DecoratorPattern.Beverages;

internal class HouseBlend : Beverage
{
    public HouseBlend(Beverage? beverage = null)
    {
        description = "House blend";
        this.baseBeverage = beverage;
        Cost = 0.89;
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