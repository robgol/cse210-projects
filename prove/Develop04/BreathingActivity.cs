class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _type = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _prompts = new List<string>() {"Breath in...", "Breath out..."};
    }
    public void DisplayBreathingCycle()
    {
        string[] cycle = {"Breath in", "Now breath out"};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
    
        int i = 0;
        
        do
        {
            Breath(cycle[i % cycle.Length]);
            Console.WriteLine();
            i++;

            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

    }

    private void Breath(string cycle)
    {
        Console.Write($"{cycle}...");
        int i = cycle == "Breath in" ? 4: 6;

        CountDown(i);

        if(cycle == "Breath in")
            Console.Write("   ");
        else
            Console.WriteLine("   ");

    }
}