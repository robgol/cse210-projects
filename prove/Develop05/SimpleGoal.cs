class SimpleGoal : Goal
{
    protected bool _completed = false; 
    public SimpleGoal():base(){}
    public SimpleGoal(string name, string description, string points, string completed):base(name, description, points)
    {
        _completed = Convert.ToBoolean(completed);
    }
    public override void Display()
    {
        string check = " ";
        if (_completed)
        {
            check = "X";
        }
        Console.WriteLine($"[{check}] {_name} ({_description})");
    }

    public override int SetComplete()
    {
        if (_completed)
        {
            Console.WriteLine("This goal is already completed, please select other goal.");
            return 0;
        }

        _completed = true;
        return _points;
    }

    public override string ToString()
    {
        return $"{base.ToString()}:{_name.ToString()},{_description.ToString()},{_points.ToString()},{_completed.ToString()}" ;
    }
}