public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        bool isComplete = IsComplete();
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal;{_shortName};{_description};{_points};{IsComplete()}";
    }
}