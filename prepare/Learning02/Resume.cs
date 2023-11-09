using System;

public class Resume
{
// Class: Resume
// Attributes:
// * _name : string
// * _jobs : List<Job>
// 
// Behaviors
// * Display() : void 
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}