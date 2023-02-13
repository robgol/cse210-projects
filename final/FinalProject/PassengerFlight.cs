class PassengerFlight : Operation
{
    private int _numPax;
    public PassengerFlight():base()
    {
        SetNumberPax();
    }
    public PassengerFlight(string operationID):base(operationID)
    {

    }
    public PassengerFlight(string operationID, string type, Flight flight, Aircraft aircraft, string date, int numberPax)
    :base(operationID, type, flight, aircraft, date)
    {
        _numPax = numberPax;
    }

    private void SetNumberPax()
    {
        
        Console.Write("Number of Passengers: ");
        _numPax = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.Clear();
        Console.WriteLine("Passenger Flight Information:");
        Console.WriteLine("<----------------------------------->");
        Console.WriteLine("Flight:");
        Console.WriteLine($"\tFlight #: {_flight.GetFlightNumber()}");;
        Console.WriteLine($"\tFrom: {_flight.GetDeptAirport()}");
        Console.WriteLine($"\tTo: {_flight.GetArrivalAirport()}");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Passenger:");
        Console.WriteLine($"\tDate: {_date}");
        Console.WriteLine($"\tTransported Passengers: {_numPax}");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Aircraft:");
        Console.WriteLine($"\tRegistration Mark: {_aircraft.GetRegMark()}");
        Console.WriteLine($"\tMake/Type: {_aircraft.GetManufacturer()} { _aircraft.GetModel()}");
        Console.ReadLine();
    }
    public override string ToString()
    {
        return $"{base.ToString()},{_operationID.ToString()},{_date},{_numPax.ToString()}\n{_flight.ToString()}\n{_aircraft.ToString()}";
    }

}