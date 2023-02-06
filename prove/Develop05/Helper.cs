using System.IO; 
static class Helper
{
    public static string[] menu =  {
                            "Create Goals",
                            "List Goals",
                            "Save Goals",
                            "Load Goals",
                            "Record Event",
                            "Quit"
                        };

    public static void ShowMenuOptions( string description, string[] menu)
    {
        Console.WriteLine($"{description}:");
        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine($"  {i+1}. {menu[i]}");
        }

    }
}