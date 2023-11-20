using System;
// one for the reference (for example "John 3:16")

public class Reference
{
    // private string _book;
    // private int _chapter;
    // private int _verseNumber;

    private List<string> _referenceList = new()
    {
        // "Matthew 5:14-16",
        "Matthew 6:24",
        // "Matthew 16:15-19",
        "Matthew 25:40",
        // "Luke 24:36-39",
        "John 3:5",
        "John 7:17",
        "John 10:16",
        "John 14:15",
        "John 17:3",
        // "Acts 7:55-56",
        "Romans 1:16",
        "1 Corinthians 10:13",
        // "1 Corinthians 15:20-22",
        "1 Corinthians 15:29",
        // "1 Corinthians 15:40-42",
        // "Ephesians 4:11-14",
        // "2 Thessalonians 2:1-3",
        // "2 Timothy 3:1-5",
        // "2 Timothy 3:16-17",
        "Hebrews 5:4",
        "James 1:5-6",
        // "James 2:17-18",
        // "Revelation 14:6-7",
        // "Revelation 20:12-13",
    };

    private Scripture scripture = new();
    private int _scriptureIndex;
    private 


    // public Reference()
    // {
    //     _book = ;
    //     _chapter = ;
    //     _verseNumber = 
    // }


    public string DisplayReference(int ind)
    {
        // needs int from Scripture.ChooseScripture to pull same number from referenceList
       Console.Write(_referenceList[ind]);
    //    return _referenceList;
        // _scriptureIndex = scripture.ChooseScripture(); 
        // Console.Write(_scriptureIndex);
    }
}