namespace StrategyPattern.Interfaces.QuackBehavior;

public class NormalQuack : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}