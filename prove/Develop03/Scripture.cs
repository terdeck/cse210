using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
// one for the scripture itself

public class Scripture
{
    private string _text; //words hidden?
    private Reference _reference;
    private List<Word> _words = new();
    private Random rng = new();

    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
        string[] wordArray = text.Split();
        foreach (string wordString in wordArray)
        {
            Word wordObj = new(wordString);
            _words.Add(wordObj);
        }
    }


    public void DisplayScripture()
    {
        Console.Write(_reference.GetReferenceString() +  " - ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
    }

    public void HideWord()
    // public HideWords(numberToHide: int) return void
    // random generator, choose 3 rando nums, pass that number/word to Words class, word will return underscores
    {
        int index;
        do{
            index = rng.Next(_words.Count);
        }while(_words[index].GetIsHidden());

        _words[index].Hide();
    }


    public bool CompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.GetIsHidden())
                return false;
        }
        return true;
    }
}