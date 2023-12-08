public class Cycling : Activity
{
    public Cycling(string date, float activityLength, float distance, float speed, float pace) : base(date, activityLength, distance, speed, pace)
    {

    }
    public override double ActDistance()
    {
        return _distance;
    }
    public override float ActSpeed()
    {
        return ((_distance / _activityLength) * 60);
    }
    public override float ActPace()
    {
        return _activityLength / _distance;
    }
    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date} Cycling ({_activityLength}) - Distance {_distance} miles, Speed {_speed}, Pace: {_pace} min per mile";
    }
}