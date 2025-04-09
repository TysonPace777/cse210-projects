public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        string completeVar = "";
        if (_isComplete == false)
        {
            completeVar = "[ ]";
        }
        else if (_isComplete == true)
        {
            completeVar = "[X]";
        }
        return $"{completeVar} {_shortName} ({_description})";
    }
}