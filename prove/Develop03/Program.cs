using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureConstructor scriptureConstructor = new();
        Scripture scripture = scriptureConstructor.GetRandomScripture();

        Console.WriteLine("Welcome to the New Testament Scripture Mastery Memorizer program! \n");
        Console.WriteLine("The program will choose a random scripture from the 25 scripture mastery scriptures. \n");
        Console.WriteLine("Let's Begin! \n");


        string choice;
        int counter;
        while(true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            choice = Console.ReadLine();

            if (choice == "quit") 
            {
                break;
            }
            if (scripture.CompletelyHidden())
            {
                break;
            }
            
            counter = 0;
            while(counter < 3 && !scripture.CompletelyHidden())
            {
                scripture.HideWord();
                counter++;
            }

            // user keeps pressing enter until whole scripture is hidden
            // once whole scripture is hidden, program quits
        }

    }
}