public class Events
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Events(Address address)
    {
        _address = address;
    }
    public string GetTitle()
    {
        return _title;
        // if this doesn't work try doing Get and Set for the four values individually
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string StandardDetails()
    {
        return ($"{_title}: {_description}. \nOn {_date}, {_time}, at\n{_address.GetAddress()}");
    }
}