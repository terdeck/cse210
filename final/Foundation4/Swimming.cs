public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, float activityLength, float distance, float speed, float pace, double _laps) : base(date, activityLength, distance, speed, pace)
    {
        _laps = laps;
    }
    public override double ActDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override float ActSpeed()
    {
        return (_distance / _activityLength) * 60;
    }
    public override float ActPace()
    {
        return _activityLength / _distance;
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date} Swimming ({_activityLength}) - Laps completed {_laps}, Distance {_distance} miles, Speed {_speed}, Pace: {_pace} min per mile";
    }
}