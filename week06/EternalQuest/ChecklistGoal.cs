public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _bonusAwarded;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _bonusAwarded = false;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int awarded = _points;
        if (!_bonusAwarded && _amountCompleted >= _target)
        {
            awarded += _bonus;
            _bonusAwarded = true;
        }
        return awarded;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Progress: {_amountCompleted}/{_target}) (Points: {_points}, Bonus: {_bonus})";
    }
}