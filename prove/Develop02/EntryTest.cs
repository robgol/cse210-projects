class EntryTest
{
    public string _prompt;
    public string _answer;
    public string _date;

    public void Display()
    {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
            Console.WriteLine(_answer);
            Console.WriteLine();
    }


}