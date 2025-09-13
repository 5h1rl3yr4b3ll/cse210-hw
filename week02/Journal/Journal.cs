using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();
    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd"),
            _promptText = prompt,
            _entryText = response
        };
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetEntryAsText());
            }
        }
        Console.WriteLine("Journal saved to file successfully.");
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length >= 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }
}