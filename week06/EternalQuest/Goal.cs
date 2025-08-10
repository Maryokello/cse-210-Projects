
using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // RecordEvent returns the points awarded for the event (0 if none)
    public abstract int RecordEvent();

    // A short details string used for lists
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }

    // Represent the goal as a savable string: Type|field1|field2|...
    public abstract string ToDataString();

    // Factory to create a Goal from a saved data string
    public static Goal FromDataString(string line)
    {
        // Format: Type|shortName|description|points|... (extra fields depend on type)
        var parts = line.Split('|');
        var type = parts[0];
        if (type == "Simple")
        {
            var shortName = parts[1];
            var description = parts[2];
            var points = int.Parse(parts[3]);
            var isComplete = bool.Parse(parts[4]);
            var g = new SimpleGoal(shortName, description, points);
            if (isComplete) g.ForceComplete();
            return g;
        }
        else if (type == "Eternal")
        {
            var shortName = parts[1];
            var description = parts[2];
            var points = int.Parse(parts[3]);
            return new EternalGoal(shortName, description, points);
        }
        else if (type == "Checklist")
        {
            var shortName = parts[1];
            var description = parts[2];
            var points = int.Parse(parts[3]);
            var amountCompleted = int.Parse(parts[4]);
            var target = int.Parse(parts[5]);
            var bonus = int.Parse(parts[6]);
            var bonusAwarded = bool.Parse(parts[7]);
            var g = new ChecklistGoal(shortName, description, points, target, bonus);
            g.SetAmountCompleted(amountCompleted);
            if (bonusAwarded) g.ForceBonusAwarded();
            return g;
        }
        else
        {
            throw new Exception("Unknown goal type: " + type);
        }
    }
}