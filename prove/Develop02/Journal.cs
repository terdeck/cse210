using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new();

    public void AddEntry()
    {
        Entry entry = new();
        entry.Write();
        _entries.Add(entry);
        Console.Clear();
    }


    public void DisplayAll()
    {
        Console.Clear();
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine();
    }


    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new(file, true))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        _entries.Clear();
        Console.Clear();
        Console.Write($"File has been saved to {file}\n\n");
    }


    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
        Console.Clear();
        Console.Write($"File has been loaded from {file}\n\n");
    }

}
