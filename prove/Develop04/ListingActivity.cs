public class ListingActivity : Activity
{
    private int _count;
    private List<string> _listPrompts = new()
    {
        "Who is someone that you appreciate?",
        "What are personal strengths of yours?",
        "Is there someone that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by making a list of as many things as you can think of in the time given.";
        _count = 0;
    }
    public string GetRandomList()
    {
        Random randomGen = new Random();
        int index = randomGen.Next(_listPrompts.Count);
        return _listPrompts[index];
    }
    public void GetListCount()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("> ");
            // Thread.Sleep(1000);
            Console.ReadLine();
            _count++;
        }
        // _count = int.Parse(Console.ReadLine());
        
    }
    // get prompt, display prompt, main loop, display how many times (count variable)

    public void RunList()
    {
        DisplayStartMessage();
        GetDuration();

        Console.Clear();
        Console.WriteLine("Get ready . . . \n\n");
        ShowAnimation();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomList()} --- \n\n");
        Console.Write($"You may begin in: ");
        ShowCountDown();

        Console.Write($"> ");
        GetListCount();
        Console.WriteLine($"You listed {_count} items! \n\n");
        
        Console.WriteLine("Well done!");
        ShowAnimation();
        DisplayEndMessage();
        Console.Clear();
    }
}