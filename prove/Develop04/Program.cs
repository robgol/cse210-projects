using System;

class Program
{
    static void Main(string[] args)
    {
       bool play = true;
       string[] menuOptions = {"Start breathing activity", "Start reflecting activity", "Start listening activity", "Quit"};
       do
       {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine($"   {i+1}. {menuOptions[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.SetDuration();
                    breathingActivity.DisplayBreathingCycle();
                    breathingActivity.DisplayEndingMessage();

                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DisplayStartingMessage();
                    reflectionActivity.SetDuration();
                    reflectionActivity.DisplayQuestion();
                    reflectionActivity.DisplayEndingMessage();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.SetDuration();
                    listingActivity.ItemsInput();
                    listingActivity.DisplayEndingMessage();
                    break;
                case 4:
                    play = false;
                    break;
                default: break;
            }
       } while (play);
    }
}