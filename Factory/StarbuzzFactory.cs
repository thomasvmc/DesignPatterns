using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory;

internal class StarbuzzFactory : Factory
{
    private Beverage CreateBeverage(BeverageType type, SizeEnum size)
    {
        return type switch
        {
            BeverageType.ESPRESSO => new Espresso(size),
            BeverageType.DOPPIO => new Espresso(null , new Espresso(size)),
            BeverageType.LUNGO => new Water(null , new Espresso(size)),
            BeverageType.MACCHIATO => new MilkFoam(new Espresso(size)),
            BeverageType.CORRETTA => new Liquor(new Espresso(size)),
            BeverageType.CON_PANNA => new Whip(new Espresso(size)),
            BeverageType.CAPPUCINNO => new MilkFoam(new SteamedMilk(new Espresso(size))),
            BeverageType.AMERICANO => new Water(null, new Water(null , new Espresso(size))),
            BeverageType.CAFFE_LATTE => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso(size)))),
            BeverageType.FLAT_WHITE => new SteamedMilk(new SteamedMilk(new Espresso(size))),
            BeverageType.ROMANA => new Lemon(new Espresso(size)),
            BeverageType.MOROCCHINO => new SteamedMilk(new Chocolate(null, new Espresso(size))),
            BeverageType.MOCHA => new Whip(new SteamedMilk(new Chocolate(null, new Espresso(size)))),
            BeverageType.BICERIN => new Whip(new WhiteChocolate(new BlackChocolate(new Espresso(size)))),
            BeverageType.BREVE => new HalfMilk(new MilkFoam(new Espresso(size))),
            BeverageType.RAF_COFFEE => new Cream(new VanillaSugar(new Espresso(size))),
            BeverageType.MEAD_RAF => new Cream(new Honey(new Espresso(size))),
            BeverageType.GALAO => new MilkFoam(new MilkFoam(new Espresso(size))),
            BeverageType.CAFFE_AFFOGATO => new IceCream(new Espresso(null, new Espresso(size))),
            BeverageType.VIENNA_COFFEE => new Whip(new Whip(new Espresso(null, new Espresso(size)))),
            BeverageType.GLACE => new IceCream(new Espresso(size)),
            BeverageType.CHOCOLATE_MILK => new Milk(new Milk(new Chocolate(size))),
            BeverageType.DEMI_CREME => new Cream(new Cream(new Espresso(null, new Espresso(size)))),
            BeverageType.LATTE_MACHIATO => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso(size)))),
            BeverageType.FREDDO => new IceCream(new Liquor(new Espresso(size))),
            BeverageType.FRAPPUCCINO => new Whip(new SteamedMilk(new Ice(new Espresso(size)))),
            BeverageType.CARAMEL_FRAPPUCCINO => new Syrup(new Cream(new SteamedMilk(new Ice(new Espresso(size))))),
            BeverageType.FRAPPE => new IceCream(new SteamedMilk(new SteamedMilk(new Espresso(size)))),
            BeverageType.IRISH_COFFEE => new Whip(new Whiskey(new Espresso(null, new Espresso(size)))),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    public override Beverage OrderDrink(BeverageType type, SizeEnum size)
    {
        Beverage beverage = CreateBeverage(type, size);
        PrintBeverage(beverage);
        return beverage;
    }
    

    private void PrintBeverage(Beverage beverage)
    {
        Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
    }
}