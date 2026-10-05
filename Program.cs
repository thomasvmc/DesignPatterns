using FacadePattern.TheaterComponents;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);
            HomeTheaterFascade homeTheaterFascade = new HomeTheaterFascade(amp, cdPlayer, dvdPlayer, popcornPopper, projector, screen, lights, tuner);
            homeTheaterFascade.WatchMovie("Die Hard");
            homeTheaterFascade.EndMovie();
        }
    }
}