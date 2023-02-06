class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _timesForBonus;
    private int _timesDone;

    public CheckListGoal():base()
    {
        SetTimesForBonus();
        SetBonusPonints();
    }
    public CheckListGoal(string name, string description, string points, string bonusPoints, string timesForBonus, string timesDone):base(name, description, points)
    {
        _timesDone = Convert.ToInt32(timesDone);
        _timesForBonus = Convert.ToInt32(timesForBonus);
        _bonusPoints = Convert.ToInt32(bonusPoints);
    }

    private void SetTimesForBonus()
    {
        _timesForBonus = Convert.ToInt32(GetUserInput("How many times does this goal need to be accomplished for a bonus? "));
    }

    private void SetBonusPonints()
    {
        _bonusPoints = Convert.ToInt32(GetUserInput($"What is the bonus for accomplishing that {_timesForBonus} times? "));
    }

    public override void Display()
    {
        string check = " ";
        if (_timesDone == _timesForBonus)
        {
            check = "X";
        }
        Console.WriteLine($"[{check}] {_name} ({_description}) --- Curently completed {_timesDone}/{_timesForBonus}");
    }

    public override int SetComplete()
    {
        if (_timesDone == _timesForBonus)
        {
            Console.WriteLine("This goal is already completed, please select other goal.");
            return 0;
        }

        _timesDone++;
        if (_timesDone == _timesForBonus)
        {
            Console.WriteLine("!!!Congratulation!!!");
            Console.WriteLine("!!!You have completed this CheckList Goal!!!");
            return _bonusPoints;

        }
        return _points;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}:{_name.ToString()},{_description.ToString()},{_points.ToString()},{_bonusPoints.ToString()},{_timesForBonus.ToString()},{_timesDone.ToString()}" ;
    }

}