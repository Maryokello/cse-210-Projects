public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Eternal goals never complete; award points every time
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description} ({_points} pts each time)";
    }

    public override string ToDataString()
    {
        // Eternal|shortName|description|points
        return $"Eternal|{_shortName}|{_description}|{_points}";
    }
}