using System.ComponentModel.Design;

public  class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        // Initializes and empty list of goals and sets the player's score to be 0.
        _score = 0;
    }
    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        Console.Clear();
        // Console.WriteLine($"You have {_score} points.");
        // Goal goal = new Goal();
        GoalManager gm = new();

        int choice = 0;
        while(choice != 6)
        {
            Console.WriteLine($"You have {_score} points. \n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // don't list up top, call method inside choice
                // menu - simple, eternal, or checklist
                gm.ListGoalNames();
                gm.CreateGoal();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                gm.ListGoalDetails();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                gm.SaveGoals(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                gm.SaveGoals(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are: ");
                gm.ListGoalDetails();
                Console.Write("Which goal did you accomplish? ");
                gm.DisplayPlayerInfo();
            }
            else if (choice == 6)
            {
                Console.WriteLine();
                Console.Write("See you next time!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }
        
    }
    public void DisplayPlayerInfo()
    {
        // Displays the players current score.
        Console.WriteLine($"Congratulations! You have earned {_score} points!");
    }
    public void ListGoalNames()
    {
        // Lists the names of each of the goals.
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int newGoal = 0;
        newGoal = int.Parse(Console.ReadLine()); // ?? here instead?

        // if else if loop for the three goal types??
    }
    public void ListGoalDetails()
    {
        // Lists the details of each goal (including the checkbox of whether it is complete).
    }
    public void CreateGoal()
    {
        // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        // Goal goal = new();
        // goal.Write();

        // Console.WriteLine("The types of Goals are:");
        // Console.WriteLine("   1. Simple Goal");
        // Console.WriteLine("   2. Eternal Goal");
        // Console.WriteLine("   3. Checklist Goal");
        // Console.Write("Which type of goal would you like to create? ");
        // int newGoal = 0;
        // newGoal = int.Parse(Console.ReadLine()); // ?? here instead?

    }
    public void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    }
    public void SaveGoals(string file)
    {
        // Saves the list of goals to a file.
        using (StreamWriter outputFile = new(file, true))
        {
            foreach(Goal goals in _goals)
            {
                outputFile.WriteLine($"{_goals}|{goals._goalName}|{goals._description}|{goals._points}|{goals._amountCompleted}|{goals._target}|{goals._bonus}");
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
            Goal goals = new();
            goals._goalName = parts[0];
            goals._description = parts[1];
            goals._points = parts[2];
            goals._amountCompleted = parts[3];
            goals._target = parts[4];
            goals._bonus = parts[5];
            _goals.Add(goals);
        }
        Console.Clear();
        Console.Write($"File has been loaded from {file}\n\n");
    }
}