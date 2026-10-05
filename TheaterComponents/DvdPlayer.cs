namespace FacadePattern.TheaterComponents
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Dvd player on");
        }
        public void Off()
        {
            Console.WriteLine("Dvd player of");
        }
        public void Eject()
        {
            Console.WriteLine("Dvd player ejecting disc");
        }
        public void Pause()
        {
            Console.WriteLine("Dvd player paused");
        }
        public void Play(string movie)
        {
            Console.WriteLine("Dvd player playing: " + movie);
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("Dvd player set surround audio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("Dvd player set two channel audio");
        }
        public void Stop()
        {
            Console.WriteLine("Dvd player stopping");
        }
    }
}
