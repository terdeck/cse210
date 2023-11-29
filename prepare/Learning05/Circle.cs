public class Circle : Shape
{
    private double _radius;

    public Circle(string paperColor, double radius) : base(paperColor)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}