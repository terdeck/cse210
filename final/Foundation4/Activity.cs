public abstract class Activity
{
    protected string _date;
    protected float _activityLength; // in mins
    protected float _distance;
    protected float _speed; // mph
    protected float _pace; // mile per min

    public Activity(string date, float activityLength, float distance, float speed, float pace)
    {
        _date = date;
        _activityLength = activityLength;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public float GetActLength()
    {
        return _activityLength;
    }
    public void SetActLength(float activityLength)
    {
        _activityLength = activityLength;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(float distance)
    {
        _distance = distance;
    }
    public float GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(float speed)
    {
        _speed = 60 / _pace;
        _speed = speed;
    }
    public float GetPace()
    {
        return _pace;
    }
    public void SetPace(float pace)
    {
        _pace = 60 / _speed;
        _pace = pace;
    }
    public abstract double ActDistance();
    public abstract float ActSpeed();
    public abstract float ActPace();
    public abstract string GetSummary();
}