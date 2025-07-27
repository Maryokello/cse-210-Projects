/// Program.cs
using System;
using System.IO;

// This program exceeds core requirements by:
// - Loading scriptures from a file (scriptures.txt)
// - Randomly selecting a scripture for memorization

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = LoadRandomScriptureFromFile("scriptures.txt");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }

    static Scripture LoadRandomScriptureFromFile(string filePath)
    
    {
        var lines = File.ReadAllLines(filePath);
        var random = new Random();
        string line = lines[random.Next(lines.Length)];
        var parts = line.Split('|');

        Reference reference;
        string text;

        if (parts.Length == 4)
        {
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            text = parts[3];
        }
        else
        {
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            text = parts[4];
        }

        return new Scripture(reference, text);
    }
}
