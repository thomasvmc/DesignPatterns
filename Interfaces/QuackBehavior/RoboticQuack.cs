namespace StrategyPattern.Interfaces.QuackBehavior;

public class RoboticQuack : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Q-U-A-C-K");
    }
}