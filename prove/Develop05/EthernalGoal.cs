class EthernalGoal : Goal
{
    public EthernalGoal():base(){}
    public EthernalGoal(string name, string description, string points):base(name, description, points){}
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override int SetComplete()
    {
        return _points;
    }
    public override string ToString()
    {
        return $"{base.ToString()}:{_name.ToString()},{_description.ToString()},{_points.ToString()}" ;
    }

}