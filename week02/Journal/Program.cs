using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        {
            Journal journal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();

            string choice = "";

            while (choice != "5")
            {
                Console.WriteLine("Please choose one of the following:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Your choice: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(newEntry);
                }
                else if (choice == "2")
                {
                    journal.DisplayAll();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter filename to save: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                }
                else if (choice == "4")
                {
                    Console.Write("Enter filename to load: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }
            }
        }
    }
}