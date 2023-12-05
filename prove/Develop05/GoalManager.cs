using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Dynamic;

public  class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _counter;
    private int _input;

    public GoalManager()
    {
        // Initializes an empty list of goals and sets the player's score to be 0.
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
        // GoalManager gm = new();  //put this in GoalManager method??

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
                // _goals.Add(new SimpleGoal(goalName, description, points));
                _goals.Add(new SimpleGoal());
            }
            else if (choice == 2)
            {
                // call eternal goal class
                _goals.Add(new EternalGoal());
            }
            else if (choice == 3)
            {
                // call checklist class
                _goals.Add(new ChecklistGoal());
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
        foreach (Goal goal in _goals)
        {
            Console.Write(_counter);
            goal.DisplayGoal();
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
        _input = int.Parse(Console.ReadLine());
    
        if (_goals[_input].GetComplete()==true)
        {
            Console.WriteLine("Goal is already completed");
        }
        else
        {
            _score += _goals[_input].RecordEvent();
        }
    }
    public void SaveGoals(string file)
    {
        // Saves the list of goals to a file.
        using (StreamWriter outputFile = new(file, true))
        {
            outputFile.WriteLine($"{_score}|{_score}");
            foreach(Goal goals in _goals)
            {
                outputFile.WriteLine(goals.GetSaveString());
            }
        }
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
            
            if (int.Parse(parts[0]) == 1)
            {
                SimpleGoal simple = new SimpleGoal(line);  
                _goals.Add(simple); 
            }
            else if (int.Parse(parts[0]) == 2)
            {
                EternalGoal eternal = new EternalGoal(line);
                _goals.Add(eternal); 
            }
            else if (int.Parse(parts[0]) == 3)
            {
                ChecklistGoal checklist = new ChecklistGoal(line);
                _goals.Add(checklist); 
            }
        }
        Console.Clear();
        Console.Write($"File has been loaded from {file}\n\n");
        DisplayGoals();
    }
}