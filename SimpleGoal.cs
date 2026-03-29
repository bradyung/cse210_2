public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDisplayString()
    {
        if (_isComplete)
        {
            return "[X] " + _name + " (" + _description + ")";
        }
        else
        {
            return "[ ] " + _name + " (" + _description + ")";
        }
    }

    public override string GetSaveString()
    {
        return "SimpleGoal#" + _name + "#" + _description + "#" + _points + "#" + _isComplete;
    }
}