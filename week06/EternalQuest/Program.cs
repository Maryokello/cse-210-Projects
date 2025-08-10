using System;

class Program
{
    static void Main(string[] args)
    {
        var gm = new GoalManager();

        // sample goals to test
        gm.AddGoal(new SimpleGoal("Read Book", "Read 20 pages", 50));
        gm.AddGoal(new EternalGoal("Exercise", "Do 30 minutes of activity", 10));
        gm.AddGoal(new ChecklistGoal("Practice", "Solve practice problems", 20, 3, 100));

        Console.WriteLine("Initial Goals:");
        gm.ShowGoals();
        Console.WriteLine($"Score: {gm.GetScore()}");

        Console.WriteLine("\nRecording an event for goal 1 (SimpleGoal):");
        int pts = gm.RecordEvent(0);
        Console.WriteLine($"Points awarded: {pts}");
        Console.WriteLine($"Score: {gm.GetScore()}");

        Console.WriteLine("\nRecording the checklist goal 3 times:");
        gm.RecordEvent(2);
        gm.RecordEvent(2);
        gm.RecordEvent(2);
        Console.WriteLine($"Score after checklist events: {gm.GetScore()}");

        Console.WriteLine("\nFinal Goals:");
        gm.ShowGoals();
    }
}