using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("✨ Welcome to the Enhanced Journal Program ✨");

        Journal journal = new();
        PromptGenerator promptGen = new();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file (JSON)");
            Console.WriteLine("4. Load the journal from a file (JSON)");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Optional - Enter a mood or tag (e.g., happy, tired, spiritual): ");
                    string tag = Console.ReadLine();

                    Entry entry = new()
                    {
                        Date = DateTime.Now.ToString("yyyy-MM-dd"),
                        PromptText = prompt,
                        EntryText = response,
                        MoodTag = tag
                    };

                    journal.AddEntry(entry);

                    // Auto-save
                    journal.SaveToFile("autosave.json");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.json): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., journal.json): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Exiting... See you next time!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please choose between 1 and 5.");
                    break;
            }
        }
    }
}

// - JSON-based save/load with System.Text.Json
// - Added mood/tag for each entry
// - Unique ID added per entry
// - Auto-save feature after new entries
