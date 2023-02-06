abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public static string[] goalTypes = {
            "Simple Goal",
            "Ethernal Goal",
            "Checklist Goal"
        };

    public Goal()
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
    }
    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = Convert.ToInt32(points);
    }
    public abstract void Display();

    public abstract int SetComplete();

    protected static string GetUserInput( string prompt)
    {
        Console.Write(prompt);
        string name = Console.ReadLine();
        return name;
    }

    protected void SetGoalName()
    {
        _name = GetUserInput("What is the name of your goal? ");
    }

    protected void SetGoalDescription()
    {
        _description = GetUserInput("What is a short description of it? ");

    }

    protected void SetGoalPoints()
    {
        _points = Convert.ToInt32(GetUserInput("What is the amount of points associated with this goal? "));

    }

}