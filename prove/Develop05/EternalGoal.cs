using System.IO; 
public  class EternalGoal : Goal
{
    // doesn't need member variables

    public EternalGoal(string goalName, string description, string points) : base(goalName, description, points)
    {
        _goalName = "What is the name of your goal?";
        _description = "What is a short description of it?";
        _points = "What is the amount of points associated with this goal?";
    }
    public override string RecordEvent()
    {
        // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
        Console.WriteLine("Congratulations");
        return _points;
    }
    public override string GetSaveString()
    {
        // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        return "GetType()|_name|_description|_points";
    }
}