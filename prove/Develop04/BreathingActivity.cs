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
            Console.WriteLine("Breathe in... \n\n");
            ShowCountDown();
            // Console.WriteLine();
            Console.WriteLine("Breathe out...\n\n");
            ShowCountDown();
            // Console.WriteLine();
        }
    }
    public void RunBreathing()
    {
        DisplayStartMessage();
        GetDuration();
        Console.WriteLine("Let's begin:");
        ShowAnimation();
        BreathingExercise();
        DisplayEndMessage();
        ShowAnimation();
        Console.Clear();
    }
}