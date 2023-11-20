using System;
using System.Reflection.PortableExecutable;
// to represent a word in the scripture (hidden)

public class Word
{

  private List<string> _text = new();

  private string _hidden;
  // _notHidden = bool
  // _indexList = create a list of indexes and remove at random to hide words

  // HideWords


  public string BlankWords(string x)
  {
  // BlankWords
    // randomized function to select words to hide
    // remove from _indexList
    foreach (var item in x)
    {
      _hidden.Add[item] = '_'; //??? add? not add?
    }
    return _hidden;
  }
  
  // CompletelyHidden() return bool
      // when count of hidden words == length of scripture
}