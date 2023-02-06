class User
{
    private int _points;
    private List<Goal> _goals = new List<Goal>();

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    private void AddGoal(int typeOfGoal)
    {
        switch (typeOfGoal)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                _goals.Add(simpleGoal);
                break;
            case 2:
                EthernalGoal ethernalGoal = new EthernalGoal();
                _goals.Add(ethernalGoal);
                break;
            case 3:
                CheckListGoal checkListGoal = new CheckListGoal();
                _goals.Add(checkListGoal);
                break;
            default: break;
        }

    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void DisplayGoals(bool showPoints = true)
    {
        Console.WriteLine("The Goals are:");
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.Display();
            i++;
        }
        if(showPoints)
            DisplayPoints();
    }

    public void CreateGoal()
    {
        Helper.ShowMenuOptions("The types of Goal are", Goal.goalTypes);
        Console.Write("Which type of goal would you like to create? ");
        int typeOfGoal = Convert.ToInt32(Console.ReadLine());
        AddGoal(typeOfGoal);
    }

    public void Save()
    {
        string filename = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_points);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
    }

    public void Load()
    {

        string filename = "myGoals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        foreach (string line in lines)
        {
            switch (i)
            {
                case 0:
                    _points = Convert.ToInt32(lines[0]);
                    i++;
                    break;
                default:
                    string[] parts = line.Split(":");

                    string typeOfGoal = parts[0];
                    
                    string[] goalString = parts[1].Split(",");

                    switch (typeOfGoal)
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(goalString[0], goalString[1], goalString[2], goalString[3]);
                            _goals.Add(simpleGoal);
                            break;

                        case "EthernalGoal":
                            EthernalGoal ethernalGoal = new EthernalGoal(goalString[0], goalString[1], goalString[2]);
                            _goals.Add(ethernalGoal);
                            break;

                        case "CheckListGoal":
                            CheckListGoal checkListGoal = new CheckListGoal(goalString[0], goalString[1], goalString[2], goalString[3], goalString[4], goalString[5]);
                            _goals.Add(checkListGoal);
                            break;

                        default:
                            break;
                    }
                break;
            }
        }            

    }

    public void RecordEvent()
    {
        DisplayGoals(false);
        Console.Write($"Which goal did you accomplish? ");
        int option = Convert.ToInt32(Console.ReadLine());

        int earnedPoints = _goals[option-1].SetComplete();
        _points += earnedPoints;
        if (earnedPoints != 0)
            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!\nYou now have {_points}\n");
    }

    private void DisplayPoints()
    {
        Console.WriteLine($"\nYou have {_points} points.\n");
    }

}