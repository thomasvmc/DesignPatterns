namespace StrategyPattern.Interfaces.QuackBehavior;

public class Squeek : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeek");
    }
}