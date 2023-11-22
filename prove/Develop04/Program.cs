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

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }
        }
    }
}