using System.Transactions;

public class Video
{
    public string _vidTitle;
    public string _vidAuthor;
    public int _vidLength; //seconds
    public List<Comment> _vidComments = new();

    public void VidDetails()
    {
        Console.WriteLine($"Video Title: {_vidTitle}");
        Console.WriteLine($"Video Author: {_vidAuthor}");
        Console.WriteLine($"Video Length in seconds: {_vidLength}");

        foreach (Comment comments in _vidComments)
        {
            comments.Display();
        }
    }
}