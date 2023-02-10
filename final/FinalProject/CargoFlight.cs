class CargoFlight: Operation
{
    private int _cargoWeight;
    public CargoFlight():base()
    {
        SetCargoWeight();
    }
    public CargoFlight(int operationID):base(operationID)
    {

    }
    public CargoFlight(int operationID, string type, Flight flight, Aircraft aircraft, string date, int cargoWeight)
    :base(operationID, type, flight, aircraft, date)
    {

    }
    private void SetCargoWeight()
    {
        Console.Write("Cargo Weight: ");
        _cargoWeight = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        throw new NotImplementedException();
    }
}