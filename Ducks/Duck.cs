using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected QuackBehavior QuackBehavior { get; set; }
        protected FlyBehavior FlyBehavior { get; set; }
        protected SwimBehavior SwimBehavior { get; set; }
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

        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        public void SetSwimBehavior(SwimBehavior swimBehavior)
        {
            SwimBehavior = swimBehavior;
        }
    }
}
