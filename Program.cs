using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            List<Duck> ducks = new List<Duck>{mallardDuck, redheadDuck, decoyDuck, rubberDuck};
            
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();
                Console.WriteLine("");
            }
            
            redheadDuck.SetFlyBehavior(new FlyWithHead());
            redheadDuck.PerformFly();
        }
    }
    
}