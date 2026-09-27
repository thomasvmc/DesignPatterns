namespace DecoratorPattern.Beverages
{
    internal abstract class BaseBeverage : Beverage
    {
        internal BaseBeverage(SizeEnum? size, Beverage? beverage = null) : base(beverage.Size ?? size)
        {
            if (beverage.Size == null && size == null) throw new ArgumentNullException("Size and the size of the base beverage cannot both be null", new Exception());
            this.baseBeverage = beverage;
        }
    }
}
