public class Swimming : Activity
{
    private double _laps;

    public Swimming() : base()
    {
        // _laps = laps;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public void SetLaps(double laps)
    {
        _laps = laps;
    }
    public override double ActDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }
    public override double ActSpeed()
    {
        _speed = _distance / _activityLength * 60;
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
        Console.WriteLine($"{_date} Swimming ({_activityLength} mins) - Laps completed {_laps}, Distance {_distance} miles, Speed {_speed}, Pace: {_pace} min per mile");
    }
}