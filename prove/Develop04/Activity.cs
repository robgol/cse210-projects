class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    protected string _type;
    private string[] _animated = {"\\","|", "/", "-" };
    protected List<string> _prompts;

    public Activity(){}
    public Activity(string title, string description, int duration)
    {
        _title = title;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_type}. \n");
        Console.WriteLine($"{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Pause(5);

        Console.WriteLine($"You have completed {_duration} seconds of the {_type}.");
        Pause(10);
    }

    public void DisplayAnimation( string message, int length = 10)
    {
        Console.Clear();
        Console.WriteLine(message);
        Pause(length);

    }

    protected void Pause(int length)
    {
        for (int i = 0; i < length; i++)
        {
            int j = i % _animated.Length;
            Thread.Sleep(500);
            Console.Write("\b\b "); // Erase the + character
            Console.Write($"{_animated[j]}");
        }

        Console.Write("\b "); // Erase the + character
        Console.WriteLine();

    }

    protected void CountDown(int time)
    {
        while (time > 0)
        {
            Console.Write($"{time}");
            Thread.Sleep(1000);
            Console.Write(" \b\b");
            time--;
        } 

    }
    
    public void DisplayPrompt()
    {
        int random = GetRamdom(_prompts.Count);
        if (_type == "Reflection Activity")
            Console.WriteLine("Consider the following prompt:");

        Console.WriteLine($"--- {_prompts[random]} ---");
        if (_type == "Reflection Activity")
        {
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.Read();
        }    
       
        Console.Write("You may begin in: ");
        CountDown(4);
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds. would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        
        DisplayAnimation("Get ready...");

    }
    protected int GetRamdom(int max)
    {
        Random random = new Random();
        return random.Next(0, max-1);
    }

    protected DateTime GetTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        return currentTime;

    }
}