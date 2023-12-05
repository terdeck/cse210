public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _points;
    protected bool _complete;

    public Goal(string goalName, string description, string points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _complete = false;

    }
    public Goal(string goalName, string description, string points, bool complete)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _complete = complete;
    }
    public bool GetComplete()
    {
    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
        return _complete;
    }
    private string GetCompleteX()
    {
    // This method will input the X for finished goals
        if (_complete == true)
        {
            return "X";
        }
        else
        {
            return "";
        }
    } 
    public virtual string DisplayGoal()
    {
    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        return "[ GetCompleteX() ] _name: _description";
    }
    public abstract string RecordEvent();
     // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public abstract string GetSaveString();
    // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.

}