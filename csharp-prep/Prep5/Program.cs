using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squareNumber = SquareNumber(number);

        DisplayResult(name, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int squared = favNumber * favNumber;
        return squared;
    }
    static void DisplayResult(string username, int squared)
    {
        Console.WriteLine($"{username}, the square of your number is {squared}");
    }
}