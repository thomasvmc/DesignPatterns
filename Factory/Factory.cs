using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factory
{
    internal abstract class Factory
    {
        public abstract Beverage OrderDrink(BeverageType type, SizeEnum size);
    }
}
