namespace DecoratorPattern.Beverages;

internal class HouseBlend : BaseBeverage
{
    public HouseBlend(SizeEnum? size, Beverage? beverage = null) : base(size, beverage)
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