abstract class Operation
{
    protected string _operationID;
    protected string _type;
    protected Flight _flight;
    protected Aircraft _aircraft;
    protected string _date;

    public Operation()
    {
        SetType();
        SetFlight();
        SetAircraft();
        SetDate();
        SetOperationID();
    }
    public Operation(string operationID)
    {

    }
    public Operation(string operationID, string type, Flight flight, Aircraft aircraft, string date)
    {
        _operationID = operationID;
        _type = type;
        _flight = flight;
        _aircraft = aircraft;
        _date = date;
    }
    protected void SetOperationID()
    {
        _operationID = $"{_flight.GetDeptAirport()} - {_flight.GetArrivalAirport()} on {_date}";
    }
    protected void SetType()
    {
        _type = base.ToString();
    }
    protected void SetAircraft()
    {
        Console.Write("Aircraf Registration Mark: ");
        string aircraft = Console.ReadLine().ToUpper();

        _aircraft = new Aircraft(aircraft);
    }
    protected void SetFlight()
    {
        Console.Write("Flight Number: ");
        string flightNumber = Console.ReadLine().ToUpper();

        _flight = new Flight(flightNumber);
    }
    protected void SetDate()
    {
        Console.Write("Date (dd-mm-yyyy): ");
        _date = Console.ReadLine();
    }
    protected string GetOperationDetail()
    {
        return "";
    }
    public abstract void Display();
    protected void Save()
    {
        string filename = Helper._operationLocation + _operationID + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write(ToString());
        }

    }
    protected void Load()
    {

    }
    public static void ManageOperation()
    {
        int option = 0;
        do
        {
            option = Helper.DisplayMenu(Helper._operation, "Manage Operation:");
            switch (option)
            {
                case 1:
                    //add passenger flight
                    Console.WriteLine("Register a Passanger Flight");
                    PassengerFlight passengerFlight = new PassengerFlight();
                    passengerFlight.Save();
                    break;
                case 2:
                    //add cargo flight
                    Console.WriteLine("Register a Cargo Flight");
                    CargoFlight cargoFlight = new CargoFlight();
                    cargoFlight.Save();
                    break;
                case 3:
                    //add Ferry Flight
                    Console.WriteLine("Register a Ferry Flight");
                    FerryFlight ferryFlight = new FerryFlight();
                    ferryFlight.Save();
                    break;
                case 4:
                    //list
                    Console.WriteLine("Flights Log: ");
                    List<string> operations = Helper.List("operations");
                    Console.Write("Pick one flight to display informations: ");
                    var selectedOperation = operations[Convert.ToInt32(Console.ReadLine())-1];
                    var operation = LoadFromFile(selectedOperation);
                    operation.Display();
                    break;
                case 5:
                    //back
                    break;
                default:
                    break;
            }
            Console.Clear();
        } while (option != 5);

    }
    public static Operation LoadFromFile(string operation)
    {
        string[] lines = System.IO.File.ReadAllLines($"operations/{operation}.txt");

        var operationType = lines[0].Split(",")[0];
        var op = lines[0].Split(",");
        var routeArray = lines[1].Split(",");
        var aircraftArray = lines[2].Split(",");
        Flight route = new Flight(routeArray[0], routeArray[1], routeArray[2]);
        Aircraft aircraft = new Aircraft(aircraftArray[0], aircraftArray[1], aircraftArray[2], Convert.ToInt32(aircraftArray[3]));
        
        switch (operationType)
        {
            case "PassengerFlight":
                var paxFlight = new PassengerFlight(op[1], op[0], route, aircraft, op[2], Convert.ToInt32(op[3]));
                return paxFlight;

            case "CargoFlight":
                var cargoFlight = new CargoFlight(op[1], op[0], route, aircraft, op[2], Convert.ToInt32(op[3]));
                return cargoFlight;
            
            case "FerryFlight":
                var ferryFlight = new FerryFlight(op[1], op[0], route, aircraft, op[2], op[3]);
                return ferryFlight;
            default:
                break;
        }

        return null;
    }

}