using System.IO; 
public  class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal() : base()
    {
        // In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.

        Console.Write("How many many times must this goal be accomplished for a bonus?");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?");
        _bonus = int.Parse(Console.ReadLine());
        _amountCompleted = 0;

        _type = 3;
    }
    public ChecklistGoal(string line) : base(line)
    {
        
    }
    public override void DisplayGoal()
    {
        // return base.DisplayGoal() + " [_amountCompleted/_target]";
        base.DisplayGoal();
        Console.WriteLine( _amountCompleted/_target);
    }
    public override int RecordEvent()
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
        // return "_type|_name|_description|_points|_complete|_amountCompleted|_target|_bonus";
        return ($"{_type}|{_goalName}|{_description}|{_points}|{_complete}|{_amountCompleted}|{_target}|{_bonus}");
    }
}