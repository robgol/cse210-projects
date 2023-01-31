class ListingActivity : Activity
{
    private List<string> _itemCounter = new List<string>();
    public ListingActivity()
    {
        _prompts = new List<string>() {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

        _type = "Listing Activity";

        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DisplayItemsAmount()
    {

    }

    public void ItemsInput()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        string input;
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        //Console.Write("\b\b\b");


        do
        {
            Console.Write("> ");
            input = Console.ReadLine();

            _itemCounter.Add(input);
            currentTime = DateTime.Now;

        } while (currentTime < futureTime);
        
        Console.WriteLine($"You have listed {_itemCounter.Count} items!\n");
    }

}