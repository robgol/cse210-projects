class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _file;

    public void Write()
    {
        
        Entry newEntry = new Entry();
        newEntry._prompt = Prompt.Random();

        Console.Write($"{newEntry._prompt} ");
        newEntry._answer = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        _entries.Add(newEntry);

    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._answer);
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry  entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._answer);
            }
        }
    }

    public void LoadFromFile()
    {

    }
}