public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
    : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override int GetPointsEarned()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_amountCompleted}/{_target} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal;{_shortName};{_description};{_points};{_target};{_bonus};{_amountCompleted}";
    }
}