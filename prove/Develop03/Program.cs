using System;

class Program
{
    static void Main(string[] args)
    {

        bool play = true;
        Scripture scripture = new Scripture("John 3:16-17");

        scripture.SetScripture();


        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetScripture());
            string input = Console.ReadLine();

            if(input != "" || scripture.NoMoreToHide())
            {
                play = false;
            }
            scripture.Hide3Words();
        } while (play);
    }
}