 using System.Diagnostics;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration; // how long user wants to spend on each activity

    public Activity()
    {
        // _name = name;
        // _description = description;
    }
    public void GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity. \n");
        Thread.Sleep(1000);
        Console.WriteLine("Well done!");
    }
    public void ShowAnimation()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
    public void ShowCountDown()
    {
        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(_duration);

        // while (DateTime.Now < endTime)
        {
            for (int n = _duration/3; n > 0; n--)
            // Console.Write(endTime - DateTime.Now);
            {
                Console.Write(n);
                Thread.Sleep(1000);
                Console.Write("\b\b \b\b");
            }   
        }
    }
}