using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the New Testament Scripture Mastery Memorizer program! \n");
        Console.WriteLine("The program will choose a random scripture from the 25 scripture mastery scriptures. \n");
        Console.WriteLine("Let's Begin! \n");

        // calls random scripture

        bool first = true;
        
        string choice = "quit";
        while(choice != "quit")
        {
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            choice = Console.ReadLine();

            if (choice == "quit") 
            {
                break;
            }
            Console.Clear();
            if (first)
            {
                Scripture.DisplayScripture();
                first = false;
            }
            else
            {
                if (Scripture.CompletelyHidden())
                {
                    break;
                }
                // Scripture.CompletelyHidden();
                Scripture.HideWords();
            }

            // user keeps pressing enter until whole scripture is hidden
            // once whole scripture is hidden, program quits
        }

    }
}
// ChooseScripture()
// loop accepting user input
    // if Enter is pressed continue
    // type quit to exit program