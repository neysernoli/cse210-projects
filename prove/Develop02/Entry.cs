public class Entry
{
    public string _promptText;
    public string _entryText;
    public DateTime _date;
    public void Display()
    {
      Console.WriteLine($"Date: {_date} - Prompt:{_promptText}");
      Console.WriteLine($"{_entryText}");
      
    }
}