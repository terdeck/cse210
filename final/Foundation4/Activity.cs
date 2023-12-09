public abstract class Activity
{
    protected string _date;
    protected double _activityLength; // in mins
    protected double _distance;
    protected double _speed; // mph
    protected double _pace; // mile per min

    public Activity()
    {
        // _date = date;
        // _activityLength = activityLength;
        // _distance = distance;
        // _speed = speed;
        // _pace = pace;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public double GetActLength()
    {
        return _activityLength;
    }
    public void SetActLength(double activityLength)
    {
        _activityLength = activityLength;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public double GetSpeed()
    {
        _speed = (_distance / _activityLength) * 60;
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = 60 / _pace;
        _speed = speed;
    }
    public double GetPace()
    {
        _pace = _activityLength / _distance;
        return _pace;
    }
    public void SetPace(double pace)
    {
        _pace = 60 / _speed;
        _pace = pace;
    }
    public abstract double ActDistance();
    public abstract double ActSpeed();
    public abstract double ActPace();
    public abstract void GetSummary();
}