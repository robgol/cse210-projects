using System.Text.Json;
using System.Text.Json.Serialization;

class Journal
{
    public List<Entry> _entries {get; set; } = new List<Entry>();
    public string _file { get; set;}

    /*
        Write an entry in the journal
    */
    public void Write()
    {
        var newEntry = Entry.Write();
        _entries.Add(newEntry);
    }

    /*
        Display the journal content. the content is a List of Entry, so print them to the terminal is done at Entry class,
        using the static void method Display, called on Entry.Display and using _entries attribut as parameter
    */
    public void Display()
    {
        Console.WriteLine("Showing Journal content:");
        Entry.Display(_entries);
        
    }

    public void SaveToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize<List<Entry>>(_entries, options);
        File.WriteAllText(_file, jsonString);
    }

    public void LoadFromFile()
    {
        string jsonString = File.ReadAllText(_file);
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString)!;
    }
}