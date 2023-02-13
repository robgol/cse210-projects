class CargoFlight: Operation
{
    private int _cargoWeight;
    public CargoFlight():base()
    {
        SetCargoWeight();
    }
    public CargoFlight(string operationID):base(operationID)
    {

    }
    public CargoFlight(string operationID, string type, Flight flight, Aircraft aircraft, string date, int cargoWeight)
    :base(operationID, type, flight, aircraft, date)
    {
        _cargoWeight = cargoWeight;
    }
    private void SetCargoWeight()
    {
        Console.Write("Cargo Weight: ");
        _cargoWeight = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.Clear();
        Console.WriteLine("Cargo Flight Information:");
        Console.WriteLine("<----------------------------------->");
        Console.WriteLine("Flight:");
        Console.WriteLine($"\tFlight #: {_flight.GetFlightNumber()}");;
        Console.WriteLine($"\tFrom: {_flight.GetDeptAirport()}");
        Console.WriteLine($"\tTo: {_flight.GetArrivalAirport()}");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Cargo:");
        Console.WriteLine($"\tDate: {_date}");
        Console.WriteLine($"\tTransported Cargo: {_cargoWeight} Tons");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Aircraft:");
        Console.WriteLine($"\tRegistration Mark: {_aircraft.GetRegMark()}");
        Console.WriteLine($"\tMake/Type: {_aircraft.GetManufacturer()} { _aircraft.GetModel()}");
        Console.ReadLine();
    }

    public override string ToString()
    {
        return $"{base.ToString()},{_operationID.ToString()},{_date},{_cargoWeight.ToString()}\n{_flight.ToString()}\n{_aircraft.ToString()}";
    }
}