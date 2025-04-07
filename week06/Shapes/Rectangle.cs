public class Rectangle : Shape
{
    private double _side1 = 0;
    private double _side2 = 0;

    public double GetSide1()
    {
        return _side1;
    }

    public double GetSide2()
    {
        return _side2;
    }

    public void SetSides(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }

    public override double GetArea()
    {  
        double area = _side1 * _side2;
        return area;
    }
}