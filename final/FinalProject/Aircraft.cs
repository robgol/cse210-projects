class Aircraft
{
    private string _regMark;
    private string _manufacturer;
    private string _type;
    private int _configuration;

    public Aircraft()
    {
        SetRegistrationMark();
        SetManufacturer();
        SetType();
        SetConfiguration();
    }
    public Aircraft(string regMark)
    {
        
    }

    public Aircraft(string regMark, string manufacturer, string type, int configuration)
    {
       _regMark = regMark;
       _manufacturer = manufacturer;
       _type = type;
       _configuration = configuration;
    }

    private void SetRegistrationMark()
    {
        Console.Write("Registration Mark: ");
        _regMark = Console.ReadLine();
    }
    private void SetManufacturer()
    {
        Console.Write("Manufacturer: ");
        _manufacturer = Console.ReadLine();
    }
    private void SetType()
    {
        Console.Write("Type: ");
        _type = Console.ReadLine();
    }

    private void SetConfiguration()
    {
        Console.Write("Configuration: ");
        _configuration = Convert.ToInt32(Console.ReadLine());
    }

    public int GetConfiguration()
    {
        return _configuration;
    }

    public void Save()
    {
        
    }

    public void Load()
    {
        
    }
    public override string ToString()
    {
        return base.ToString();
    }
}