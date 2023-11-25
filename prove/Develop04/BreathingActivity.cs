using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void BreathingExercise()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in... \n");
            ShowCountDown();
            // Console.WriteLine();
            Console.WriteLine("Breathe out...\n");
            ShowCountDown();
            // Console.WriteLine();
        }
    }
    public void RunBreathing()
    {
        Console.Clear();
        DisplayStartMessage();
        GetDuration();
        Console.Clear();
        Console.WriteLine("Let's begin:");
        ShowAnimation();
        Console.WriteLine();
        
        BreathingExercise();
        ShowAnimation();
        DisplayEndMessage();
        ShowAnimation();
        Thread.Sleep(2000);
        Console.Clear();
    }
}