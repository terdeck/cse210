using System;

public class PromptGenerator
{
    // public List<Prompt> _prompts = new List<Prompt>();
    public List<string> _prompts = new List<string>()
    {
        "What memory are you grateful for?",
        "What opportunities are you grateful for?",
        "What is something a friend of family member did today that made you thankful for them?",
        "What is the biggest gift in your life right now?",
        "What talents and abilities are you most grateful for?"
    };
    
    public string GetRandomPrompt()
    {
        Random randomGenerate = new Random();
        int index = randomGenerate.Next(_prompts.Count);
        return _prompts[index];
    }

    // list of prompts:
    // What memory are you grateful for?
    // What opportunities are you grateful for?
    // What is something a friend of family member did today that made you thankful for them?
    // What is the biggest gift in your life right now?
    // What talents and abilities are you most grateful for?
}