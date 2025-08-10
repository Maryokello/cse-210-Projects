using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public bool RemoveGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals.RemoveAt(index);
            return true;
        }
        return false;
    }

    // Record an event for the goal at the given index. Returns points awarded.
    public int RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            return points;
        }
        return 0;
    }

    public void ShowGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("(No goals yet)");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GetScore() => _score;

    // Save to a text file. First line is score, then one line per goal using ToDataString().
    public void Save(string path)
    {
        using (var sw = new StreamWriter(path))
        {
            sw.WriteLine(_score);
            foreach (var g in _goals)
            {
                sw.WriteLine(g.ToDataString());
            }
        }
    }

    // Load from a text file (overwrites current goals and score)
    public void Load(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        var lines = File.ReadAllLines(path);
        if (lines.Length == 0) return;
        _goals.Clear();
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;
            var g = Goal.FromDataString(lines[i]);
            _goals.Add(g);
        }
    }
}