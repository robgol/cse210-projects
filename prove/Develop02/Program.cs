using System;
class Program
{
    static void Main(string[] args)
    {
        int userMenuChoice = 0; 
        Journal myJournal = new Journal();

        do
        {
            Helper.DisplayMenu();
            Console.Write("What do you want to do? ");
            userMenuChoice = Convert.ToInt32(Console.ReadLine());

            if (userMenuChoice == 1)
            {
                Console.Clear();
                myJournal.Write();
            }
            else if (userMenuChoice == 2)
            {
                Console.Clear();
                myJournal.Display();
            }
            else if (userMenuChoice == 3)
            {
                Console.Clear();
                Console.Write("What is the file name (including .json)? ");
                myJournal._file = Console.ReadLine();
                myJournal.LoadFromFile();                
            }
            else if (userMenuChoice == 4)
            {
                Console.Clear();
                Console.Write("What is the file name (including .json)? ");
                myJournal._file = Console.ReadLine();
                myJournal.SaveToFile();                
            }
            else if (userMenuChoice == 5)
            {
                Console.WriteLine("See you!");
                break;
            }            
        } while (true);
    }
}