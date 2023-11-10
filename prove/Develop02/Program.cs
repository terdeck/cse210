using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");


        Console.WriteLine("Please select one of the following choices: ");
        
        DisplayMenu();

        string prompt1 = new string();
        // PromptGenerator prompt1 = new PromptGenerator();
        prompt1._prompts = "What memory are you grateful for?";

        string prompt2 = new string();
        prompt2._prompts = "What opportunities are you grateful for?";

        string prompt3 = new string();
        prompt3._prompts = "What is something a friend of family member did today that made you thankful for them?";
        
        string prompt4 = new string();
        prompt4._prompts = "What is the biggest gift in your life right now?";

        string prompt5 = new string();
        prompt5._prompts = "What talents and abilities are you most grateful for?";

    // Welcome to the Journal Program!
    // Please select one of the following choices:
    // Menu: Write, Display, Load, Save, Quit
    // What would you like to do? input
    // >
    }
    static void DisplayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
        int choiceInput = -1;

        while(choiceInput != 5) 
        {
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            int choice = int.Parse(input); 

            if (choice == 1)
            {
                return Entry;
            }
            else if (choice == 2)
            {
                return Journal;
            }
            else if (choice == 3)
            {
                return Journal;
            }
            else if (choice == 4)
            {
                return Journal;
            }
            else if (choice == 5)
            {
                Console.Write("See you next time!");
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }
    }
}