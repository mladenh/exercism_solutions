public class SpaceAge
{
    private readonly int _seconds;
    private const double Earth = 31557600;
    private const double Mercury = 0.2408467;
    private const double Venus = 0.61519726;
    private const double Mars = 1.8808158;
    private const double Jupiter = 11.862615;
    private const double Saturn = 29.447498;
    private const double Uranus = 84.016846;
    private const double Neptune = 164.79132;

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() => _seconds / Earth;

    public double OnMercury() => OnEarth() / Mercury;

    public double OnVenus() => OnEarth() / Venus;

    public double OnMars() => OnEarth() / Mars;

    public double OnJupiter() => OnEarth() / Jupiter;

    public double OnSaturn() => OnEarth() / Saturn;

    public double OnUranus() => OnEarth() / Uranus;

    public double OnNeptune() => OnEarth() / Neptune;

}