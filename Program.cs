namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFascade homeTheaterFascade = new HomeTheaterFascade();
            homeTheaterFascade.WatchMovie("Die Hard");
        }
    }
}