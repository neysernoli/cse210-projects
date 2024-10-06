using System.IO;
using System.Linq.Expressions;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry (string promptText, string entryText)
    {
        Entry newEntry = new Entry
        {
            _promptText = promptText,
            _entryText = entryText,
            _date = DateTime.Now
        };
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._promptText}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        using (StreamReader reader  = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    DateTime entryDate = DateTime.Parse(line.Substring(6));
                    string Prompt = reader.ReadLine()?.Substring(8);
                    string entryText = reader.ReadLine()?.Substring(7);

                    Entry newEntry = new Entry
                    {
                        _date = entryDate,
                        _promptText = Prompt,
                        _entryText = entryText
                    };
                    
                    _entries.Add(newEntry);
                }
            }
        }
    }
}