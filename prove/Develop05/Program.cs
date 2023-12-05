using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager gm = new ();

        int choice = 0;
        while(choice != 6)
        {
            Console.WriteLine();
            gm.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // don't list up top, call method inside choice
               gm.AddGoal();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                gm.DisplayGoals();
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                gm.SaveGoals(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                gm.LoadGoals(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are: ");
                gm.RecordEvent();
                Console.Write("Which goal did you accomplish? ");
                gm.DisplayPlayerInfo();
            }
            else if (choice == 6)
            {
                Console.WriteLine();
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