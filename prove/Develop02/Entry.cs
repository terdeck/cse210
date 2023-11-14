using System;
using System.Threading.Tasks.Dataflow;

// random
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public PromptGenerator promptGen = new();


    public void Write()
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptGen.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}