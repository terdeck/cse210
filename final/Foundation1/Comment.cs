public class Comment
{
    public string _name;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Commentor name: {_name}");
        Console.WriteLine($"Comment text: {_text}");
    }
}