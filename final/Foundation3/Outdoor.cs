public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, DateTime dateTime, Address address, string weather) 
        : base(title, description, dateTime, address)
    {
        _weather = weather;
    }
    public override string FullDesc()
    {
        string baseDetails = ShortDesc();
        return $"{baseDetails}\nType: Outdoor Activity\nWeather: {_weather}";
    }
}