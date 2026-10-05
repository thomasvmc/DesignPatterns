namespace FacadePattern;

public class HomeTheaterFascade
{
    private static Lazy<Amplifier> amp = new (() => new Amplifier());
    private static Lazy<CdPlayer> cdPlayer = new (() => new CdPlayer(amp.Value));
    private static Lazy<DvdPlayer> dvdPlayer = new (() => new DvdPlayer(amp.Value));
    private static Lazy<PopcornPopper> popcornPopper = new (() => new PopcornPopper());
    private static Lazy<Projector> projector = new (() => new Projector());
    private static Lazy<Screen> screen = new (() => new Screen());
    private static Lazy<TheaterLights> lights = new (() => new TheaterLights());
    private static Lazy<Tuner> tuner = new (() => new Tuner(amp.Value));

    public void WatchMovie(string movie)
    {
        popcornPopper.Value.On();
        popcornPopper.Value.Pop();

        lights.Value.Dim(10);

        screen.Value.Down();

        projector.Value.On();
        projector.Value.SetInput(dvdPlayer.Value);
        projector.Value.WideScreenMode();

        amp.Value.On();
        amp.Value.SetDvd(dvdPlayer.Value);
        amp.Value.SetSurroundSound();
        amp.Value.SetVolume(5);

        dvdPlayer.Value.On();
        dvdPlayer.Value.Play(movie);
    }
}