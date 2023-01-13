using System.Text.Json;
using System.Text.Json.Serialization;

class Journal
{
    public List<Entry> _entries {get; set; } = new List<Entry>();
    public string _file { get; set;}

    public void Write()
    {
        
        Entry newEntry = new Entry();
        newEntry._prompt = Prompt.Random();

        Console.Write($"{newEntry._prompt} ");
        newEntry._answer = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        var entry = new Entry
            {
                _date = newEntry._date,
                _prompt = newEntry._prompt,
                _answer = newEntry._answer
            };
        
        _entries.Add(entry);

    }

    public void Display()
    {
        Console.WriteLine("Showing Journal content:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry?._date} - Prompt: {entry?._prompt}");
            Console.WriteLine(entry?._answer);
            Console.WriteLine();
        }
    }

    public void SaveToFile(/*string fileName*/)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize<List<Entry>>(_entries, options);
        File.WriteAllText(_file, jsonString);
    }

    public void LoadFromFile(/*string fileName*/)
    {

        string jsonString = File.ReadAllText(_file);
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString)!;

    }
}