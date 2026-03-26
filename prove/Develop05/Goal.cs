class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;
    public Goal()
    {
        _name = "";
        _description = "";
        _status = false;
        _numberOfPoints = 0;
        _goalType = "";
    }
    public void SetName()
    {
        Console.WriteLine("Please enther the name of your goal: ");
        _name = Console.ReadLine();
    }
    public virtual string GetConsoleString()
    {
        return $"Goal information: {_name}";
    }
}