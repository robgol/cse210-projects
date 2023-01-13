class Prompt
{
    public List<string> _prompts  {get; set; } = new List<string>();
    private static string _file = "prompts.txt";

    public static string Random()
    {
        Prompt prompts = new Prompt();
        prompts.LoadFromFile();

        Random rnd = new Random();
        int randonPrompt = rnd.Next(0, prompts._prompts.Count);

        return prompts._prompts[randonPrompt];
    }

    public void Write()
    {
        
    }
    
    public void Delete()
    {

    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {
        string fileName = _file;
        string[] prompts = System.IO.File.ReadAllLines(fileName);

        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
        }
    }
}