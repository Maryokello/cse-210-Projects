using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        // Exercise 3
        Console.WriteLine("\nHello World! This is the Exercise3 Project.");

        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("Guess the magic number (1-100): ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber) Console.WriteLine("Lower!");
                else if (guess < magicNumber) Console.WriteLine("Higher!");
            }

            Console.WriteLine($"You guessed it in {guessCount} attempts!");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");

        
    }
}
