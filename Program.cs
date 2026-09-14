using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);
            
            Beverage caramelCappuccino = new Espresso();
            caramelCappuccino = new Ice(caramelCappuccino);
            caramelCappuccino = new SteamedMilk(caramelCappuccino);
            caramelCappuccino = new CreamSyrup(caramelCappuccino);
            PrintBeverage(caramelCappuccino);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}