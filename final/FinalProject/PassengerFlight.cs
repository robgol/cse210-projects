class PassengerFlight : Operation
{
    private int _numPax;
    public PassengerFlight():base()
    {
        SetNumberPax();
    }
    public PassengerFlight(int operationID):base(operationID)
    {

    }
    public PassengerFlight(int operationID, string type, Flight flight, Aircraft aircraft, string date, int numberPax)
    :base(operationID, type, flight, aircraft, date)
    {

    }

    private void SetNumberPax()
    {
        
        Console.Write("Number of Passengers: ");
        _numPax = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {

    }

}