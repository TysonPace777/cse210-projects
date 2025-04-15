public class Swimming : Activity
{
    private double _laps;

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override double GetPace()
    {
        double pace = _length / GetDistance();
        return pace;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
}