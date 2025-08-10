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
}