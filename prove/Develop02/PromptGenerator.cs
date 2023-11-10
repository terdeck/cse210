using System;

public class PromptGenerator
{
    // public List<Prompt> _prompts = new List<Prompt>();
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        Random randomGenerate = new Random();
        int randomNum = randomGenerate.Next(1, 6);

        string getPrompt = _prompts[randomNum];

        // foreach (string prompt in _prompts)
        // {
        //     // prompt.Display();
        // Console.WriteLine(getPrompt);
        return getPrompt;
    }

    // list of prompts:
    // What memory are you grateful for?
    // What opportunities are you grateful for?
    // What is something a friend of family member did today that made you thankful for them?
    // What is the biggest gift in your life right now?
    // What talents and abilities are you most grateful for?
}