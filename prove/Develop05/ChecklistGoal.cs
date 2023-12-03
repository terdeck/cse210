using System.IO; 
public  class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal() : base()
    {
        // In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.
        
        _goalName = "What is the name of your goal?";
        _description = "What is a short description of it?";
        _points = "What is the amount of points associated with this goal?";

        Console.Write("How many many times must this goal be accomplished for a bonus?");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?");
        _bonus = int.Parse(Console.ReadLine());
        _amountCompleted = -1;
    }
    public override void RecordEvent()
    {
        // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    }
    public override bool IsComplete()
    {
        // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    }
    public override string GetDetailsString()
    {
        // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    }
    public override string GetStringRepresentation()
    {
        // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    }
}