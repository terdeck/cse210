using System;
using System.IO;

public class Journal
{
    // public List<Entry> _entries = new List<Entry>();
    public List<Entry> _entries;
    // public string _newEntry;
    // public string _file;

    public void AddEntry(Entry newEntry)
    {
        string input = Console.ReadLine();

        Entry inputEntry = new Entry();
        _entries.Add(inputEntry);
        // newEntry.Display();
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: {entry}");
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the filename? ");
        string input = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(input))
        {
            outputFile.WriteLine();
        }
        // file.Display();
        // writing
    }
    public void LoadFromFile(string file)
    {
        Console.Write("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Display();
            // date prompt entry
        }
        // parts.Display();
        // Display(parts);
        // reading
    }

}
