using System.Text.Json;
using System.Text.Json.Serialization;
class Flight
{
    private string _number{get; set;}
    private string _deptAirport {get; set;}
    private string _arrivalAirport {get; set;}
    //private string _deptTime;
    //private string _arrivalTime;

    public Flight(){}
    public Flight(bool condition)
    {
        SetNumber();
        SetDeptAirport();
        //SetArrivalTime();
        SetArrivalAirport();
        //SetArrivalTime();

    }
    public Flight(string number)
    {
        string[] lines = System.IO.File.ReadAllLines($"flights/{number}.txt");

        var parts = lines[0].Split(",");
        _number = parts[0];
        _deptAirport = parts[1];
        _arrivalAirport = parts[2];
    }
    public Flight(string number, string deptAirport, string arrivalAirport)
    {
        _number = number;
        _deptAirport = deptAirport;
        _arrivalAirport = arrivalAirport;
    }

    private void SetNumber()
    {
        Console.Write("Flight Number: ");
        _number = Console.ReadLine().ToUpper();
    }
    private void SetDeptAirport()
    {
        Console.Write("Departure Airport: ");
        _deptAirport = Console.ReadLine().ToUpper();
    }
    private void SetArrivalAirport()
    {
        Console.Write("Destination Airport: ");
        _arrivalAirport = Console.ReadLine().ToUpper();
    }
    public string GetDeptAirport()
    {
        return _deptAirport;
    }
    public string GetArrivalAirport()
    {
        return _arrivalAirport;
    }
    public string GetFlightNumber()
    {
        return _number;
    }
/*     private void SetDeptTime()
    {
        Console.Write("Deptarture Time: ");
        _deptTime = Console.ReadLine();
    }
    private void SetArrivalTime()
    {
        Console.Write("Arrival Time: ");
        _arrivalTime = Console.ReadLine();
    }
 */
    public override string ToString()
    {
        return $"{_number},{_deptAirport},{_arrivalAirport}";
    }
    
    public void Save()
    {
        string filename = Helper._flightLocation + _number + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write(ToString());
        }
    }

    private void Display()
    {
        Console.Clear();
        Console.WriteLine("Flight Information:");
        Console.WriteLine($"\tFlight #: {_number}");
        Console.WriteLine($"\tFrom: {_deptAirport}");
        Console.WriteLine($"\tTo: {_arrivalAirport}");
        Console.ReadLine();
    }
    public static void ManageRoutes()
    {
        int option = 0;
        do
        {
            option = Helper.DisplayMenu(Helper._baseOptions, "Manage Routes:");
            switch (option)
            {
                case 1:
                    //add
                    Console.WriteLine("Add a new route to system.");
                    Flight flight = new Flight(true);
                    flight.Save();
                    break;
                case 2:
                    //list
                    Console.WriteLine("Existing routes: ");
                    List<string> flights = Helper.List("flights");
                    Console.Write("Pick one flight to display informations: ");
                    Flight flight1 = new Flight(flights[Convert.ToInt32(Console.ReadLine())-1]);
                    flight1.Display();
                    break;
                case 3:
                    //delete
                    Console.WriteLine("Existing routes: ");
                    flights = Helper.List("flights");
                    Console.Write("Which flight do you want to delete? ");
                    File.Delete($"flights/{flights[Convert.ToInt32(Console.ReadLine())-1]}.txt");
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