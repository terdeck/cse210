public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _points;

    public Goal()
    {
        // _goalName = goalName;
        // _description = description;
        // _points = points;

    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();
    
    public abstract string GetStringRepresentation();

}