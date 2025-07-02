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
        }
    }
}
