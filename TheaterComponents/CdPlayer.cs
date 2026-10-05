namespace FacadePattern.TheaterComponents
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Cd player on");
        }
        public void Off()
        {
            Console.WriteLine("Cd player off");
        }
        public void Eject()
        {
            Console.WriteLine("Cd player ejecting disc");
        }
        public void Pause()
        {
            Console.WriteLine("Cd player paused");
        }
        public void Play()
        {
            Console.WriteLine("Cd player playing...");
        }
        public void Stop()
        {
            Console.WriteLine("Cd player stopped");
        }
    }
}
