class Entry
{
    public string _prompt { get; set; }
    public string _answer { get; set; }
    public string _date { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_answer}");
    }
}