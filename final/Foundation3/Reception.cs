public class Reception : Events
{
    private string _rsvp;

    public Reception(Address address) : base(address)
    {
        _address = address;
    }
    public string GetReception()
    {
        return _rsvp;
    }
    public void SetReception(string rsvp)
    {
        _rsvp = rsvp;
    }
    public string FullDetails()
    {
        return $"{StandardDetails()} \nReception Event: Send your RSVP information to {_rsvp}";
    }
    public string ShortDescription()
    {
        return $"Reception Event: {_title}, {_date}";
    }
}