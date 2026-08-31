namespace StrategyPattern.Interfaces.FlyBehavior;

public class NormalFly : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}