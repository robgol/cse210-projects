class ReflectionActivity: Activity
{
    private List<string> _reflectionPrompts = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" 
        };
    public ReflectionActivity()
    {
        _prompts = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless. "               
        };

        _type = "Reflection Activity";

        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        DisplayPrompt();

        Console.Clear();
        int random = GetRamdom(_reflectionPrompts.Count);

        do
        {
            Console.Write($"> {_reflectionPrompts[random]}  ");
            _reflectionPrompts.Remove(_reflectionPrompts[random]);
            Pause(20);
            random = GetRamdom(_reflectionPrompts.Count);

            currentTime = DateTime.Now;

        } while (currentTime < futureTime);

        Console.WriteLine();

    }
}