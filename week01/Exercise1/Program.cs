using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {last} {first}");
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();

        int gradePercentage = int.Parse(gradeInput);
        string letter = "";
        string sign = "";

        // Step 1: Determine letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Step 2: Determine sign (last digit of percentage)
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Step 3: Apply exceptions
        if (letter == "A" && sign == "+")
        {
            sign = "";  // No A+
        }

        if (letter == "F")
        {
            sign = "";  // No F+, F-
        }

        // Step 4: Display result
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Step 5: Feedback
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You have the potential to do better!");
            Console.WriteLine("Hello World! This is the Exercise3 Project.");

            string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a new random number each time
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guessCount = 0;
            int guessNumber = -1;

            Console.Write("Guess the magic number between 1 and 100: ");

            // Keep looping until the user guesses correctly
            while (guessNumber != number)
            {
                guessNumber = int.Parse(Console.ReadLine());
                guessCount++;

                if (guessNumber > number)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("Higher!");
                }
            }

            Console.WriteLine($"You guessed it in {guessCount} attempts!");

            // Ask to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
   } 
   }
