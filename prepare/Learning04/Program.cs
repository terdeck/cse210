using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        assign1.SetStudent("Samuel Bennett");
        assign1.SetTopic("Multiplication");

        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment();
        assign2.SetStudent("Roberto Rodriguez");
        assign2.SetTopic("Fractions");
        assign2.SetSection("7.3");
        assign2.SetProblems("8-19");

        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment();
        assign3.SetStudent("Mary Waters");
        assign3.SetTopic("European History");
        assign3.SetTitle("The Causes of World War II");

        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());

    }
}