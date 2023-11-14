using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Journal journal = new();
        int choice = 0;
        while(choice != 5)
        {
            Console.WriteLine("Welcome to the journal program! Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
    
            choice = int.Parse(Console.ReadLine()); 

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                Console.Write("See you next time!");
                return;
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }
    }
}