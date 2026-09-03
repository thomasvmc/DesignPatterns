namespace StrategyPattern.Interfaces.FlyBehavior;

public class FlyWithHead : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Spins head to fly!");
    }
}