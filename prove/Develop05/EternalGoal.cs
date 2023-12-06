using System.IO; 
public  class EternalGoal : Goal
{
    // doesn't need member variables

    public EternalGoal() : base()
    {
        _type = 2;
    }
    public EternalGoal(string line) : base(line)
    {
        
    }
    public override int RecordEvent()
    {
        // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
        if (_complete == false)
        {
            Console.WriteLine("Congratulations");
            _complete = true;
            return _points;
        }
        else
        {
            // goal is already complete
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }
    public override string GetSaveString()
    {
        // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        return ($"{_type}|{_goalName}|{_description}|{_points}");
    }
}