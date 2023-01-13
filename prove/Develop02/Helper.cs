class Helper
{
    public static string GetTodayDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return dateText;
    }

        public static void DisplayMenu()
    {
        string[] menuList = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
        foreach (string menu in menuList)
        {
            Console.WriteLine(menu);
        }
    }


}