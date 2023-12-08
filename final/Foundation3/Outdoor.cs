public class Outdoor : Events
{
    private string _weather;

    public Outdoor(Address address) : base(address)
    {
        _address = address;
    }
    public string GetOutdoor()
    {
        return _weather;
    }
    public void SetOutdoor(string weather)
    {
        _weather = weather;
    }
    public string FullDetails()
    {
        return $"{StandardDetails()} \nOutdoor Event: The forecast for the event should be {_weather}. Please plan accordingly.";
    }
    public string ShortDescription()
    {
        return $"Outdoor Event: {_title}, {_date}";
    }
}