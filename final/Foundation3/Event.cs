public class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    
    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetTitle()
{
    return _title;
}

public DateTime GetDateTime()
{
    return _dateTime;
}

public Address GetAddress()
{
    return _address;
}
public string ShortDesc()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_dateTime}\nAddress: \n{_address.GetFullAddress()}";
    }

public virtual string FullDesc()
    {
        return ShortDesc();
    }
}
