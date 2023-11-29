public class Square : Shape
{
    private double _side;

    public Square(string paperColor, double side) : base(paperColor)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}