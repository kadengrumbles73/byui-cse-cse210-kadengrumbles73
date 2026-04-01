public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, DateTime dateTime, Address address, string email) 
        : base(title, description, dateTime, address)
    {
        _email = email;
    }
    public override string FullDesc()
    {
        string baseDetails = ShortDesc();
        return $"{baseDetails}\nType: Lecture\nRSVP Email: {_email}";
    }
}