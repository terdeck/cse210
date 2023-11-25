using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        while(choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // don't list up top, call method inside choice
                BreathingActivity act1 = new();
                act1.RunBreathing();
            }
            else if (choice == 2)
            {
                ReflectingActivity act2 = new();
                act2.RunReflect();
            }
            else if (choice == 3)
            {
                ListingActivity act3 = new();
                act3.RunList();
            }
            else if (choice == 4)
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