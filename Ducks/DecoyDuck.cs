using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new NoFly();
            SwimBehavior = new Float();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
