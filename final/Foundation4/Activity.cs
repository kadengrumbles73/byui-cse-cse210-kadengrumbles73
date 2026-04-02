public class Activity
{
    private DateOnly _date;
    private int _minutes;

    public  Activity(DateOnly date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace() 
    {
        return _minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }

    public int GetMinutes()
    {
        return _minutes;
    }
}