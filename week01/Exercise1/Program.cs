using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {last} {first}");

        // Exercise 2
        Console.WriteLine("\nHello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);

        string letter = "";
        string sign = "";

        if (gradePercentage >= 90) letter = "A";
        else if (gradePercentage >= 80) letter = "B";
        else if (gradePercentage >= 70) letter = "C";
        else if (gradePercentage >= 60) letter = "D";
        else letter = "F";

        int lastDigit = gradePercentage % 10;
        if (lastDigit >= 7) sign = "+";
        else if (lastDigit < 3) sign = "-";
        else sign = "";

        if (letter == "A" && sign == "+") sign = "";
        if (letter == "F") sign = "";

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You have the potential to do better!");
        }

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

        // Exercise 4
        Console.WriteLine("\nHello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int inputNumber = -1;

        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
                numbers.Add(inputNumber);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The total sum is: {sum}");

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Count > 0 ? numbers.Max() : 0;
        Console.WriteLine($"The max number is: {max}");

        // Exercise 5
        Console.WriteLine("\nHello World! This is the Exercise5 Project.");
        DisplayMessage();

        string name = PromptUserName();
        DisplayPersonalMessage(name);

        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);

        DisplayResult(name, square);
    }

    // Exercise 5 Methods
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Number Squaring Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static void DisplayPersonalMessage(string name)
    {
        Console.WriteLine($"Nice to meet you, {name}!");
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}
