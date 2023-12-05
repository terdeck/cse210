using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Dynamic;

public  class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _counter;

    public GoalManager()
    {
        // Initializes and empty list of goals and sets the player's score to be 0.
        _score = 0;
        _counter = 0;
        // GoalManager gm = new();
    }
    public void AddGoal()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        Console.Clear();
        // Console.WriteLine($"You have {_score} points.");
        // Goal goal = new Goal();
        GoalManager gm = new();  //put this in GoalManager method??

        int choice = 0;
        while(choice != 4)
        {
            Console.WriteLine("   1. Simple");
            Console.WriteLine("   2. Eternal");
            Console.WriteLine("   3. Checklist");
            Console.WriteLine("   4. Go back to main menu");
            Console.Write("   Select a goal: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // don't list up top, call method inside choice
                // call simple class
            }
            else if (choice == 2)
            {
                // call eternal goal class
            }
            else if (choice == 3)
            {
                // call checklist class
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }
        
    }
    public void DisplayGoals()
    {
        _counter = 1;
        foreach (Goal goals in _goals)
        {
            Console.WriteLine("_counter" + goals.DisplayGoal());
            _counter++;
        }
    }
    public void DisplayPlayerInfo()
    {
        // Displays the players current score.
        Console.WriteLine($"Congratulations! You have earned {_score} points!");
    }
    public void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        Console.WriteLine("The goals are:");
        DisplayGoals();
        Console.Write("Which goal did you accomplish?");
        string input = Console.ReadLine();
    
        if (_goals[input].GetComplete()==true)
        {
            Console.WriteLine("Goal is already completed");
        }
        else
        {
            _score += _goals[input].RecordEvent();
        }
    }
    public void SaveGoals(string file)
    {
        // Saves the list of goals to a file.
        using (StreamWriter outputFile = new(file, true))
        {
            outputFile.WriteLine("score|_score");
            foreach(Goal goals in _goals)
            {
                outputFile.WriteLine(goals.GetSaveString());
            }
        }
        _goals.Clear();
        Console.Clear();
        Console.Write($"File has been saved to {file}\n\n");
    }
    public void LoadGoals(string file)
    {
        // Loads the list of goals from a file.
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Goal goals = new Goal();
            goals._goalName = parts[0];
            goals._description = parts[1];
            goals._points = parts[2];
            goals._amountCompleted = parts[3];
            goals._target = parts[4];
            goals._bonus = parts[5];
            goals.Add(goals);
        }
        Console.Clear();
        Console.Write($"File has been loaded from {file}\n\n");
    }
}