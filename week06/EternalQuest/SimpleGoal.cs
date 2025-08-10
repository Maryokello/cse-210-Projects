// Creativity: Added a simple leveling system (level = score / 500) and gamification features (save/load, bonuses) — documented for submission.
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return ($"[" + (_isComplete ? "X" : " ") + "] " + _shortName + " - " + _description + " (" + _points + " pts)");
    }

    public override string ToDataString()
    {
        // Simple|shortName|description|points|isComplete
        return $"Simple|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    // helper methods for loading
    public void ForceComplete() => _isComplete = true;
}