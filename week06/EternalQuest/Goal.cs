using System.Diagnostics.Metrics;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual int GetPointsEarned()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        bool complete = IsComplete();
        string completeVar = "";
        if (complete == false)
        {
            completeVar = "[ ]";
        }
        else if (complete == true)
        {
            completeVar = "[X]";
        }

        return $"{completeVar} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}