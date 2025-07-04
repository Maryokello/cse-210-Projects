using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

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

        
    }
}
