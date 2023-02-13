class Aircraft
{
    private static string[] _baseOptions = {
            "1. Add",
            "2. Delete",
            "3. Display",
            "4. Display All",
            "5. Back"
        };

    private string _regMark;
    private string _manufacturer;
    private string _type;
    private int _configuration;
    private string _fileLocation = "aircrafts/";

    public Aircraft()
    {
        SetRegistrationMark();
        SetManufacturer();
        SetType();
        SetConfiguration();
    }
    public Aircraft(string regMark)
    {
        string[] lines = System.IO.File.ReadAllLines($"aircrafts/{regMark}.txt");

        var parts = lines[0].Split(",");
        _regMark = parts[0];
        _manufacturer = parts[1];
        _type = parts[2];
        _configuration = Convert.ToInt32(parts[3]);
    }

    public Aircraft(string regMark, string manufacturer, string type, int configuration)
    {
       _regMark = regMark;
       _manufacturer = manufacturer;
       _type = type;
       _configuration = configuration;
    }

    private void SetRegistrationMark()
    {
        Console.Write("Registration Mark: ");
        _regMark = Console.ReadLine().ToUpper();
    }
    private void SetManufacturer()
    {
        Console.Write("Manufacturer: ");
        _manufacturer = Console.ReadLine();
    }
    private void SetType()
    {
        Console.Write("Type: ");
        _type = Console.ReadLine();
    }

    private void SetConfiguration()
    {
        Console.Write("Configuration: ");
        _configuration = Convert.ToInt32(Console.ReadLine());
    }

    public int GetConfiguration()
    {
        return _configuration;
    }
    public string GetRegMark()
    {
        return _regMark;
    }
    public string GetModel()
    {
        return _type;
    }
    public string GetManufacturer()
    {
        return _manufacturer;
    }


    public void Save()
    {
        string filename = _fileLocation + _regMark + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write(ToString());
        }
    }

    public void Load()
    {
        
    }
    public override string ToString()
    {
        return $"{_regMark},{_manufacturer},{_type},{_configuration}";
    }
    private void Display()
    {
        Console.Clear();
        Console.WriteLine("Aircraft Details:");
        Console.WriteLine($"\tRegistration Mark: {_regMark}");
        Console.WriteLine($"\tManufacturer: {_manufacturer}");
        Console.WriteLine($"\tModel: {_type}");
        Console.WriteLine($"\tCapacity: {_configuration}");
        Console.ReadLine();
    }
    public static void ManageAircraft()
    {
        int option = 0;
        do
        {
            option = Helper.DisplayMenu(Helper._baseOptions, "Manage Fleet:");
            switch (option)
            {
                case 1:
                    //add
                    Console.WriteLine("Add a new aircraft to system.");
                    Aircraft aircraft = new Aircraft();
                    aircraft.Save();
                    break;
                case 2:
                    //list
                    Console.WriteLine("My fleet: ");
                    List<string> aircrafts = Helper.List("aircrafts");
                    Console.Write("Pick one flight to display informations: ");
                    aircraft = new Aircraft(aircrafts[Convert.ToInt32(Console.ReadLine())-1]);
                    aircraft.Display();
                    break;
                case 3:
                    //delete
                    Console.WriteLine("Existing routes: ");
                    aircrafts = Helper.List("aircrafts");
                    Console.Write("Which aircraft do you want to delete? ");
                    File.Delete($"aircrafts/{aircrafts[Convert.ToInt32(Console.ReadLine())-1]}.txt");
                    break;
                default:
                    break;
            }
            Console.Clear();
        } while (option != 4);

        /*
            "1. Add",
            "2. Delete",
            "3. Display",
            "4. Display All",
            "5. Back"

        */
    }
}