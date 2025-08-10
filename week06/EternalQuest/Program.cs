using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var gm = new GoalManager();
        const string SAVEFILE = "eternal_quest_save.txt";

        // Simple leveling creativity: level up every 500 points
        void ShowStatus() => Console.WriteLine($"Score: {gm.GetScore()}  | Level: {gm.GetScore() / 500}");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event (complete a goal)");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Show score & level");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(gm);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                gm.ShowGoals();
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                gm.ShowGoals();
                Console.Write("Enter goal number to record: ");
                if (int.TryParse(Console.ReadLine(), out int idx))
                {
                    int pts = gm.RecordEvent(idx - 1);
                    Console.WriteLine($"Points awarded: {pts}");
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                gm.Save(SAVEFILE);
                Console.WriteLine($"Saved to {SAVEFILE}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                gm.Load(SAVEFILE);
                Console.WriteLine($"Loaded from {SAVEFILE}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                ShowStatus();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }

    static void CreateGoal(GoalManager gm)
    {
        Console.WriteLine();
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        var c = Console.ReadLine();
        Console.Write("Short name: ");
        var name = Console.ReadLine();
        Console.Write("Description: ");
        var desc = Console.ReadLine();
        Console.Write("Points (integer): ");
        int points = int.TryParse(Console.ReadLine(), out points) ? points : 0;

        if (c == "1")
        {
            gm.AddGoal(new SimpleGoal(name, desc, points));
            Console.WriteLine("Simple goal created.");
        }
        else if (c == "2")
        {
            gm.AddGoal(new EternalGoal(name, desc, points));
            Console.WriteLine("Eternal goal created.");
        }
        else if (c == "3")
        {
            Console.Write("Target times (integer): ");
            int target = int.TryParse(Console.ReadLine(), out target) ? target : 1;
            Console.Write("Bonus points when target reached (integer): ");
            int bonus = int.TryParse(Console.ReadLine(), out bonus) ? bonus : 0;
            gm.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
            Console.WriteLine("Checklist goal created.");
        }
        else
        {
            Console.WriteLine("Unknown type.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}