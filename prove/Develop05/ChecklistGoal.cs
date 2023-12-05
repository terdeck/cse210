using System.IO; 
public  class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string goalName, string description, string points, int target, int bonus) : base(goalName, description, points)
    {
        // In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.
        
        _goalName = "What is the name of your goal?";
        _description = "What is a short description of it?";
        _points = "What is the amount of points associated with this goal?";

        Console.Write("How many many times must this goal be accomplished for a bonus?");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?");
        _bonus = int.Parse(Console.ReadLine());
        _amountCompleted = 0;
    }
    public ChecklistGoal(string goalName, string description, string points, bool complete, int amountCompleted, int target, int bonus) : base(goalName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override string DisplayGoal()
    {
        return base.DisplayGoal() + " [_amountCompleted/_target]";
    }
    public override string RecordEvent()
    {
        // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {   
            _complete = true;
            Console.WriteLine("Congratulations");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine("Congratulations");
            return _points;
        }
    }
    public override string GetSaveString()
    {
        // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        return "GetType()|_name|_description|_points|_complete|_amountCompleted|_target|_bonus";
    }
}