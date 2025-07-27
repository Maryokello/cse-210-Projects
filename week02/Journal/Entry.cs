using System;

public class Entry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }
    public string MoodTag { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
        Console.WriteLine($"Mood/Tag: {MoodTag}");
        Console.WriteLine("----------------------------------");
    }
}
