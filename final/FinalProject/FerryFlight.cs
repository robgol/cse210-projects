class FerryFlight: Operation
{
    private string _purpose;
    public FerryFlight():base()
    {
        SetPurpose();
    }
    public FerryFlight(string operationID):base(operationID)
    {

    }
    public FerryFlight(string operationID, string type, Flight flight, Aircraft aircraft, string date, string purpose)
    :base(operationID, type, flight, aircraft, date)
    {
        _purpose = purpose;
    }
    private void SetPurpose()
    {
        Console.Write("Purpose: ");
        _purpose = Console.ReadLine();
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
        Console.WriteLine("Details:");
        Console.WriteLine($"\tAircraft Reg: {_aircraft.GetRegMark()}");
        Console.WriteLine($"\tDate: {_date}");
        Console.WriteLine($"\tReason: {_purpose}");
        Console.ReadLine();
    }

    public override string ToString()
    {
        return $"{base.ToString()},{_operationID.ToString()},{_date},{_purpose}\n{_flight.ToString()}\n{_aircraft.ToString()}";
    }

}