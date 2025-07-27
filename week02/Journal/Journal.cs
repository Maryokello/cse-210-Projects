using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> Entries { get; set; } = new();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(Entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved to JSON successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            Entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new();
            Console.WriteLine("Journal loaded from JSON successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
