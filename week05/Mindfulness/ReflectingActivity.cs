using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you stood up for something you believed in."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel at the time?",
        "What did you learn from this experience?",
        "How can you apply this lesson in the future?"
    };

    public ReflectingActivity() : base(
        "Reflecting Activity", 
        "This activity will help you reflect on moments of strength in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{_questions[index % _questions.Count]} ");
            ShowSpinner(5);
            Console.WriteLine();
            index++;
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
