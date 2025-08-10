
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

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }
}
