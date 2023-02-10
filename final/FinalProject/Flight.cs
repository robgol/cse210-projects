class Flight
{
    private string _number;
    private string _deptAirport;
    private string _arrivalAirport;
    private string _deptTime;
    private string _arrivalTime;

    public Flight()
    {
        SetNumber();
        SetDeptAirport();
        SetArrivalTime();
        SetArrivalAirport();
        SetArrivalTime();
    }
    public Flight(string number)
    {
        
    }
    public Flight(string number, string deptAirport)
    {

    }

    private void SetNumber()
    {
        Console.Write("Flight Number: ");
        _number = Console.ReadLine();
    }
    private void SetDeptAirport()
    {
        Console.Write("Departure Airport: ");
        _deptAirport = Console.ReadLine();
    }
    private void SetArrivalAirport()
    {
        Console.Write("Destination Airport: ");
        _arrivalAirport = Console.ReadLine();
    }
    private void SetDeptTime()
    {
        Console.Write("Deptarture Time: ");
        _deptTime = Console.ReadLine();
    }
    private void SetArrivalTime()
    {
        Console.Write("Arrival Time: ");
        _arrivalTime = Console.ReadLine();
    }
    public override string ToString()
    {
        return base.ToString();
    }
}