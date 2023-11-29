public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string paperColor, double length, double width) : base(paperColor)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}