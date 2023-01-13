using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        myJournal.Write();
        myJournal.Write();


        myJournal.Display();
        myJournal.SaveToFile();

        Console.WriteLine("Hello Develop02 World!");
    }


    public void DisplayMenu()
    {
        string[] menuList = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
        foreach (string menu in menuList)
        {
            
        }
    }

}