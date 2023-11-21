using System;
using System.Reflection.PortableExecutable;
// to represent a word in the scripture (hidden)

public class Word
{

  private string _text;     //Original text
  private string _hidden;   //Hidden text
  private bool _isHidden;   //Status of the word (whether or not it is hidden)

  public Word(string text)
  {
    _text = text;
    _isHidden = false;
    foreach (char letter in text)
    {
      _hidden += '_';
    }
  }
  
  public string GetText()
  {
    if(_isHidden)
      return _hidden;
    else
      return _text;
  }

  public bool GetIsHidden()
  {
    return _isHidden;
  }

  public void Hide()
  {
    _isHidden = true;
  }
}