using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarbuzzFactory starbuzzFactory = new StarbuzzFactory();
            Beverage espresso = starbuzzFactory.OrderDrink(BeverageType.ESPRESSO,  SizeEnum.GRANDE);
            Beverage lungo = starbuzzFactory.OrderDrink(BeverageType.LUNGO, SizeEnum.VENDI);
            Beverage lungo2 = starbuzzFactory.OrderDrink(BeverageType.LUNGO, SizeEnum.GRANDE);
            Beverage lungo3 = starbuzzFactory.OrderDrink(BeverageType.LUNGO, SizeEnum.TALL);
            Beverage americano = starbuzzFactory.OrderDrink(BeverageType.AMERICANO, SizeEnum.TALL);
            Beverage morocchino = starbuzzFactory.OrderDrink(BeverageType.MOROCCHINO, SizeEnum.GRANDE);
            Beverage chocolateMilk = starbuzzFactory.OrderDrink(BeverageType.CHOCOLATE_MILK, SizeEnum.TALL);
        }
    }
}