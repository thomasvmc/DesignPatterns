using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new Squeek();
            SwimBehavior = new NormalSwim();
            FlyBehavior = new NormalFly();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
        }
    }
}
