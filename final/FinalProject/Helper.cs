class Helper
{
    public static string _flightLocation = "flights/";
    public static string _operationLocation = "operations/";

    public static string mainMenuMsg = "Welcome to Airline Manager Sistem:";
    public static string[] mainMenu = {
            "  1. Fleet",
            "  2. Routes",
            "  3. Operation",
            "  4. Quit"
        };
    public static string[] _baseOptions = {
        "  1. Add",
        "  2. List",
        "  3. Delete",
        "  4. Back"
    };
    public static string[] _operation = {
        "  1. Register Passenger Flight",
        "  2. Register Cargo Flight",
        "  3. Register Ferry Flight",
        "  4. List",
        "  5. Back"
    };

    public static int DisplayMenu(string[] options, string message)
    {
        Console.WriteLine(message);
        foreach (var menu in options)
        {
            Console.WriteLine(menu);
        }
        Console.Write("Select one of the option above: ");
        int option = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return option;

    }

    public static void UserInteraction()
    {
        
    }

    public static List<string> List(string folder)
    {
        List<string> items = new List<string>();
        int i = 1;
        string [] fileEntries = Directory.GetFiles(folder);
        foreach(string fileName in fileEntries)
        {
            var parts = fileName.Split("\\");
            var file = parts[1].Split(".");
            var record = file[0];
            Console.WriteLine($"  {i}. {record}");
            i++;
            items.Add(record);
        }
        return items;
    }

}