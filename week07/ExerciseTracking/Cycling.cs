public class Cycling : Activity
{
    private double _speed;
    
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed * _length) / 60.0;
        return distance;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}