abstract class Operation
{
    private int _operationID;
    private string _type;
    private Flight _flight;
    private Aircraft _aircraft;
    private string _date;

    public Operation()
    {

    }
    public Operation(int operationID)
    {

    }
    public Operation(int operationID, string type, Flight flight, Aircraft aircraft, string date)
    {

    }
    protected void SetOperationID()
    {

    }
    protected void SetType()
    {
        _type = base.ToString();
    }
    protected void SetAircraft()
    {

    }
    protected void SetFlight()
    {

    }
    protected void SetDate()
    {
        Console.Write("Date: ");
        _date = Console.ReadLine();
    }
    protected string GetOperationDetail()
    {
        return "";
    }
    public abstract void Display();
    protected void Save()
    {

    }
    protected void Load()
    {

    }

}