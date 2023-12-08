public class Lecture : Events
{
    private string _speakerName;
    private int _capacity;

    public Lecture(Address address) : base(address)
    {
        _address = address;
    }
    public string GetLecture()
    {
        return $"{_speakerName} {_capacity}";
    }
    public void SetLecture(string speakerName, int capacity)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public string FullDetails()
    {
        return $"{StandardDetails()} \nLecture Event: {_speakerName}, Room capacity: {_capacity}";
    }
    public string ShortDescription()
    {
        return $"Lecture Event: {_title}, {_date}";
    }
}