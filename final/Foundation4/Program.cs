using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new();

        Running run = new("08 Dec 2023", 30, 3, 6, 10);
        // string date, float activityLength, float distance, float speed, float pace
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

        Cycling bike = new("09 Dec 2023", 30, 3, 6, 10);

        Swimming swim = new("10 Dec 2023", 30, 3, 6, 10, 30);
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