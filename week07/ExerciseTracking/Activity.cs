public abstract class Activity
{
    protected string _date = "";
    protected int _length = 0;

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min): Distance {GetDistance():0.0} miles, " +
            $"Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}