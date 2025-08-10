using System;
using System.Collections.Generic;

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
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GetScore() => _score;

    // Stubs for Save/Load (implement later)
    public void Save(string path) { /* TODO: serialize goals and score */ }
    public void Load(string path) { /* TODO: deserialize goals and score */ }
}