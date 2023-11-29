using System.Drawing;

public abstract class Shape
{
    protected string _paperColor;

    public Shape(string paperColor)
    {
        _paperColor = paperColor;
    }
    public string GetColor()
    {
        return _paperColor;
    }
    public void SetColor(string paperColor)
    {
        _paperColor = paperColor;
    }

public abstract double GetArea();

}