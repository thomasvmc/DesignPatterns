namespace FacadePattern.TheaterComponents
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater lights on");
        }

        public void Off()
        {
            Console.WriteLine("Theater lights off");
        }

        public void Dim(int value)
        {
            Console.WriteLine("Set brightness to");
        }
    }
}
