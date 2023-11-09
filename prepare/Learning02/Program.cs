using System;

// Class: Job
// Attributes:
// * _company : string
// * _jobTitle : string
// * _startYear : int
// * _endYear : int
// 
// Behaviors   
// * Display() : void

// Class: Resume
// Attributes:
// * _name : string
// * _jobs : List<Job>
// 
// Behaviors
// * Display() : void 

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        
        // "Software Engineer (Microsoft) 2019-2022"
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // "Manager (Apple) 2022-2023"
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Console.WriteLine($"{job1._company}");
        // Console.WriteLine($"{job2._company}");

        // job1.Display();
        // job2.Display();
        
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}