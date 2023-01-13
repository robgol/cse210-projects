class Entry
{
    public string _prompt { get; set; }
    public string _answer { get; set; }
    public string _date { get; set; }

    public static void Display(List<Entry> entries)
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry?._date} - Prompt: {entry?._prompt}");
            Console.WriteLine(entry?._answer);
            Console.WriteLine();
        }
    }

    public static Entry Write()
    {
        Entry newEntry = new Entry();
        
        newEntry._prompt = Prompt.Random();
        Console.Write($"{newEntry._prompt} ");
        newEntry._answer = Console.ReadLine();

        var entry = new Entry
            {
                _date = Helper.GetTodayDate(),
                _prompt = newEntry._prompt,
                _answer = newEntry._answer
            };

        return entry;
    }
}