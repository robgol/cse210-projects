class FerryFlight: Operation
{
    private string _purpose;
    FerryFlight():base()
    {
        SetPurpose();
    }
    FerryFlight(int operationID):base(operationID)
    {

    }
    FerryFlight(int operationID, string type, Flight flight, Aircraft aircraft, string date, string purpose)
    :base(operationID, type, flight, aircraft, date)
    {

    }
    private void SetPurpose()
    {
        Console.Write("Purpose: ");
        _purpose = Console.ReadLine();
    }
    public override void Display()
    {
        throw new NotImplementedException();
    }
}