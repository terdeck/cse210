using System.IO;
public  class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal() : base()
    {
        _goalName = "What is the name of your goal?";
        _description = "What is a short description of it?";
        _points = "What is the amount of points associated with this goal?";

        _isComplete = false;
    }
    public override void RecordEvent()
    {
        // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

        
    }
    public override bool IsComplete()
    {
        // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.

        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.

    }
}