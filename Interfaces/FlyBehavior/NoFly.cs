namespace StrategyPattern.Interfaces.FlyBehavior;

public class NoFly : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}