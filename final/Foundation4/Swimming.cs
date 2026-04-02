public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateOnly date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }
}