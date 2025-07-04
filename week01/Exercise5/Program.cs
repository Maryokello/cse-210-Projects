using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
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
