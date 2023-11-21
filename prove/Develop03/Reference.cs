using System;
// one for the reference (for example "John 3:16")

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;


    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }


    public string GetReferenceString()
    {
        if (_endVerse == null)
            return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
}