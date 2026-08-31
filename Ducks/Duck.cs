using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected QuackBehavior QuackBehavior { get; init; }
        protected FlyBehavior FlyBehavior { get; init; }
        protected SwimBehavior SwimBehavior { get; init; }
        public abstract void Display();

        public void PerformQuack()
        { 
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformSwim()
        {
            SwimBehavior.Swim();
        }
    }
}
