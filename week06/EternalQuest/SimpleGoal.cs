public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
       if (_isComplete)
        {
            Console.WriteLine("Goal already completed");
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"You earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal;{_shortName};{_description};{_points};{_isComplete}";
    }
}