using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        Random randomGenerate = new Random();
        int magicNumber = randomGenerate.Next(1, 101);

        int guessInput = -1;

        while (guessInput != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessInput = int.Parse(guess);

            if (guessInput < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessInput > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            // Console.WriteLine(magicNumber);
        }
    }
}