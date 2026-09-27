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
            Beverage espresso = starbuzzFactory.CreateBeverage(BeverageType.ESPRESSO,  SizeEnum.GRANDE);
            PrintBeverage(espresso);

            Beverage lungo = starbuzzFactory.CreateBeverage(BeverageType.LUNGO, SizeEnum.VENDI);
            PrintBeverage(lungo);

            Beverage americano = starbuzzFactory.CreateBeverage(BeverageType.AMERICANO, SizeEnum.TALL);
            PrintBeverage(americano);

            Beverage morocchino = starbuzzFactory.CreateBeverage(BeverageType.MOROCCHINO, SizeEnum.GRANDE);
            PrintBeverage(morocchino);
            
            Beverage chocolateMilk = starbuzzFactory.CreateBeverage(BeverageType.CHOCOLATE_MILK, SizeEnum.TALL);
            PrintBeverage(chocolateMilk);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}