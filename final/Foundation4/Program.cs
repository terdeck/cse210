using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new();

        Running run = new();
        run.SetDate("08 Dec 2023");
        run.SetActLength(30);
        run.SetDistance(3);
        run.SetPace(10);
        run.SetSpeed(6);
        // string date, float activityLength, float distance, float speed, float pace
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

        Cycling bike = new();
        bike.SetDate("09 Dec 2023");
        bike.SetActLength(30);
        bike.SetDistance(3);
        bike.SetPace(10);
        bike.SetSpeed(6);

        Swimming swim = new();
        swim.SetLaps(30);
        swim.SetDate("10 Dec 2023");
        swim.SetActLength(30);
        swim.SetDistance(3);
        swim.SetPace(10);
        swim.SetSpeed(6);
        // string date, float activityLength, float distance, float speed, float pace, double _laps

        act.Add(run);
        act.Add(bike);
        act.Add(swim);

        foreach (Activity a in act)
        {
            Console.WriteLine();
            a.GetSummary();
        }
    }
}