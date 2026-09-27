using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factory
{
    internal abstract class Factory
    {
        public abstract Beverage CreateBeverage(BeverageType type, SizeEnum size);
    }
}
