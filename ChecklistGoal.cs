public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _targetAmount)
        {
            _amountCompleted++;

            if (_amountCompleted == _targetAmount)
            {
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _targetAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDisplayString()
    {
        string box = "[ ]";

        if (IsComplete())
        {
            box = "[X]";
        }

        return box + " " + _name + " (" + _description + ") -- Completed " + _amountCompleted + "/" + _targetAmount + " times";
    }

    public override string GetSaveString()
    {
        return "ChecklistGoal#" + _name + "#" + _description + "#" + _points + "#" + _targetAmount + "#" + _bonus + "#" + _amountCompleted;
    }
}