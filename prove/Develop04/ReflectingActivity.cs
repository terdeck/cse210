public class ReflectingActivity : Activity
{
    private List<string> _refPrompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _refQuestions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }  
    public string GetRandomReflectPrompt()
    {
        Random randomGen = new Random();
        int index = randomGen.Next(_refPrompts.Count);
        return _refPrompts[index];
    }
    public string GetRandomReflectQuestion()
    {
        Random randomGen = new Random();
        int index = randomGen.Next(_refQuestions.Count);
        return _refQuestions[index];
    } 
    public void ReflectExercise()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetRandomReflectQuestion()} \n");
            ShowAnimation();
            Console.WriteLine();
        }
    }
    // DisplayPrompt and DisplayQuestion can both be part of Run
        public void RunReflect()
    {   
        DisplayStartMessage();
        GetDuration();

        Console.WriteLine("Get ready . . . \n\n");
        Console.WriteLine("Consider the following prompt: \n\n");
        Console.WriteLine($"--- {GetRandomReflectPrompt()} --- \n\n");
        Console.WriteLine("When you have something in mind, press enter to continue. \n\n");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown();

        Console.Clear();
        ReflectExercise();
        ShowAnimation();
        DisplayEndMessage();
        ShowAnimation();
        Thread.Sleep(2000);
        Console.Clear();

    }
}