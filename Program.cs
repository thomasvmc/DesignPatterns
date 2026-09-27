using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso(SizeEnum.GRANDE);
            PrintBeverage(espresso);

            Beverage lungo = new Espresso(SizeEnum.VENDI);
            lungo = new Water(null, lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso(SizeEnum.TALL);
            americano = new Water(null, americano);
            americano = new Water(null, americano);
            PrintBeverage(americano);
            
            Beverage caramelCappuccino = new Espresso(SizeEnum.GRANDE);
            caramelCappuccino = new Ice(caramelCappuccino);
            caramelCappuccino = new SteamedMilk(caramelCappuccino);
            caramelCappuccino = new CreamSyrup(caramelCappuccino);
            PrintBeverage(caramelCappuccino);
            
            Beverage darkRoastMochaWhip = new DarkRoast(SizeEnum.GRANDE);
            darkRoastMochaWhip = new Mocha(darkRoastMochaWhip);
            darkRoastMochaWhip = new Whip(darkRoastMochaWhip);
            PrintBeverage(darkRoastMochaWhip);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}