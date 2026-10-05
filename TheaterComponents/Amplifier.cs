namespace FacadePattern.TheaterComponents
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier set stereo sound");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier set surround sound");
        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier set volume to:" + volume);
        }
    }
}
