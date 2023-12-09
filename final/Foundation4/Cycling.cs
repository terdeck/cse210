public class Cycling : Activity
{
    public Cycling() : base()
    {

    }
    public override double ActDistance()
    {
        return _distance;
    }
    public override double ActSpeed()
    {
        _speed = (_distance / _activityLength) * 60;
        return _speed;
    }
    public override double ActPace()
    {
        _pace = _activityLength / _distance;
        return _pace;
    }
    public override void GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date} Cycling ({_activityLength} mins) - Distance {_distance} miles, Speed {_speed}, Pace: {_pace} min per mile");
    }
}