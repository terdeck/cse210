using System.Diagnostics;

public class Activity{
    protected string _name;
    protected string _description;
    protected string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDuration()
    {
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n\n");
        Console.WriteLine(_description);
    }
    public void DisplayEndMessage()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
        }
        
        Console.Write("Done");
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
        }

        Console.Write("Done");
    }
}